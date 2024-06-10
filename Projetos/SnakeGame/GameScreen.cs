using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SnakeGame
{
    public partial class GameScreen : Form
    {
        //Criando nossas variáveis necessarias:
        private List<Circle> Snake = new List<Circle>(); //Criando uma lista do tipo Circle, 
                                                        //essa por sua vez será responsável por guardar as informações do corpo da cobra;

        private Circle Apple = new Circle(); //Criando um objeto que será nossa maçã;

        //Nossos efeitos sonoros:
        private SoundPlayer eating = new SoundPlayer(Properties.Resources.eating);
        private SoundPlayer diying = new SoundPlayer(Properties.Resources.collision);

        //Regristro de Pontuação máxima: (Se eu fizesse na classe ela ia ser reiniciada sempre);
        private int TopScore = 0;


        public GameScreen()
        {
            InitializeComponent();


            new Settings(); //vinculando a classe Settings a este formulário;

            GameTimer.Interval = 1000 / Settings.Speed; //Mudando a velocidade do jogo com base na velocidade definida nas Configurações;
            GameTimer.Tick += updateScreen; //Vinculando uma função ao Timer;
            GameTimer.Start(); //Iniciando o Timer;

            /*StartGame(); //Começando o jogo;*/

        }

        //Fazendo uma rapida verificação se jogaremos ou não:
        private void GameScreen_Load(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Deseja Iniciar ?", "Snake Game", MessageBoxButtons.YesNo))
                Close();
            else
                StartGame(); //Começando o jogo;
        }



        private void updateScreen(object sender, EventArgs e)
        {
            //Essa é a função que atualizará a nossa tela de jogo a cada momento;

            if (Settings.GameOver == true)
            {
                //Se o jogo estiver em modo GameOver e o jogador apertar Enter, então recomeçaremos:
                if (Input.keyPress(Keys.Enter))
                {
                    StartGame(); //Começando o jogo;
                }
            }
            else
            {
                //Se o jogo não estiver em modo de GameOver,
                //então faremos as seguintes verificações e agiremos confome as teclas que forem pressionadas:
                //Não permitiremos que ela vá de baixo para cima ou da esquerda para direita, e vice-versa;

                if ( (Input.keyPress(Keys.Left) || Input.keyPress(Keys.A) ) && Settings.direction != Directions.Right ) //Esquerda
                {
                    Settings.direction = Directions.Left;
                }
                else if ( (Input.keyPress(Keys.Right) || Input.keyPress(Keys.D) ) && Settings.direction != Directions.Left ) //Direita
                {
                    Settings.direction = Directions.Right;
                }
                else if ( (Input.keyPress(Keys.Up) || Input.keyPress(Keys.W) ) && Settings.direction != Directions.Down ) //Cima
                {
                    Settings.direction = Directions.Up;
                }
                else if ( (Input.keyPress(Keys.Down) || Input.keyPress(Keys.S) ) && Settings.direction != Directions.Up ) //Baixo
                {
                    Settings.direction = Directions.Down;
                }

                MovePlayer(); //Realizando a movimentação;

            }

            GameCanvas.Invalidate(); //Atualiza a PictureBox e atualiza os gráficos;
        }


        private void keyisdown(object sender, KeyEventArgs e)
        {
            //Essa função acionará a mundança de direção em que nossa cobra se move:
            Input.changeState(e.KeyCode, true);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            //Aqui é onde veremos a cobra e seu corpo se movendo:

            Graphics canvas = e.Graphics; //Criando um novo objeto da class Graphics;

            if ( Settings.GameOver == false )
            {
                //Se o jogo for válido então faremos o seguinte:

                Brush snakeColor;  //variável responsável por armazenar as cores que utilizaremos;

                //Laço de repetição para confeccionar nossa cobra:
                for ( int i=0; i<Snake.Count; i++ )
                {
                    if (i==0)
                    {
                        //Pintando a cabeça da cobra:
                        snakeColor = Brushes.Black;
                    }
                    else
                    {
                        //Pintando o resto do corpo:
                        snakeColor = Brushes.Green;
                    }

                    //Desenhando a cobra:
                    canvas.FillEllipse(snakeColor, 
                                       new Rectangle(
                                                     Snake[i].X * Settings.Width, //Posição X da cobra;
                                                     Snake[i].Y * Settings.Height,//Posição Y da cobra;
                                                     Settings.Width, Settings.Height //Largura e Altura dela;
                                                    ));
                    //Desenhando a maça:
                    canvas.FillEllipse(Brushes.Red,
                                       new Rectangle(
                                                     Apple.X * Settings.Width, //Posição X da maça;
                                                     Apple.Y * Settings.Height,//Posição Y da maçã;
                                                     Settings.Width, Settings.Height //Largura e Altura dela;
                                                    ));
                }
            }
            else
            {
                //Aqui é o que acontecerá quando tivermos um GameOver
                //Faremos nossa label que contem a mensagem de fim de jogo ser visivel:

                string gameover = "Fim de Jogo\n\n" + "Pontuação: " + Settings.Score + "\n\n Tecle Enter Para Recomeçar.\n";

                //Passamos o nosso recorde de pontuação? 
                if ( Settings.Score > TopScore ) 
                    TopScore = Settings.Score; //Somando as pontuações Obtidas

                int x = (GameCanvas.Size.Width - txtGameMessage.Size.Width) / 2;
                int y = (GameCanvas.Size.Height - txtGameMessage.Size.Height) / 2;

                txtGameMessage.Location = new Point(x, y);
                txtGameMessage.Text = gameover;
                txtGameMessage.Visible = true;
            }

        }

        private void StartGame()
        {
            //Começando nosso jogo:
            txtGameMessage.Visible = false; //Escondendo nossa mensagem;
            new Settings(); //Criando uma nova instância;
            Snake.Clear(); //Limpando nossa lista/excluindo as partes existentes da cobra;
            Circle head = new Circle { X = 10, Y = 5 }; //Criando uma nova cabeça para a cobra;
            Snake.Add(head); //adicionando a cabeça no array do corpo da cobra;

            txtActualScore.Text = Settings.Score.ToString(); //Mostrando a pontuação;
            txtActualTopScore.Text = TopScore.ToString();

            GenerateFood(); //Gerando comida;
        }

        private void MovePlayer()
        {
            //Laço de repetição principal para a cabeça e o corpo da cobra:
            for ( int i= Snake.Count-1; i>=0; i-- )
            {
                //Se tivermos a cabeça da cobra:
                if ( i==0 )
                {
                    //Movendo o resto do corpo de acordo com a direção escolhida:
                    switch(Settings.direction)
                    {
                        case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;
                    }

                    //Restringindo a cobra para ela não sair da nossa tela:
                    int maxXpos = GameCanvas.Size.Width / Settings.Width;
                    int maxYpos = GameCanvas.Size.Height / Settings.Height;

                    //Realizando a verificação para sabermos se estamos fora dos limites (nossa tela):
                    if (
                            Snake[i].X < 0 ||
                            Snake[i].Y < 0 ||
                            Snake[i].X > maxXpos ||
                            Snake[i].Y > maxYpos
                        )
                    {
                        //Então temos um GameOver:
                        Die();
                    }

                    //Detecção de colisão da cabeça com o corpo:
                    for ( int j=1; j<Snake.Count; j++ )
                    {
                        if ( Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y )
                        {
                            //Se houver a colisão então:
                            Die();
                        }
                    }

                    //Verificando se houve a colisão com a maça:
                    if ( Snake[0].X == Apple.X && Snake[0].Y == Apple.Y )
                    {
                        Eat();
                    }

                }
                else
                {
                    //Se não houverem colisões então continuamos movendo a cobra e seu corpo:
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void GenerateFood()
        {
            int maxXpos = GameCanvas.Size.Width / Settings.Width; //Encontrando a Posição X máxima;
            int maxYpos = GameCanvas.Size.Height / Settings.Height; //Encontrando a Posição Y máxima;

            Random rdm = new Random(); //Criando uma instância da classe Random;

            Apple = new Circle { X = rdm.Next(0, maxXpos), Y = rdm.Next(0, maxYpos) }; //Gerando a nova localização da maçã;
        }

        private void Eat()
        {

            eating.Play();

            //Crescendo o corpo da cobra:
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body); //Adicionando ao corpo;
            Settings.Score += Settings.Points; //Pegando os pontos por comer a maçã;
            txtActualScore.Text = Settings.Score.ToString(); //Mostrando o placar atualizado;
            GenerateFood(); //Chamando uma nova maçã;
        }

        private void Die()
        {
            diying.Play();
            Settings.GameOver = true; //Morrendo;
        }


    }

}
