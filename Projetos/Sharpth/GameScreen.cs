using System;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace Sharpth
{
    public partial class GameScreen : Form
    {
        //Variáveis necessárias:
        bool goLeft, goRight, jumping, isGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 3;
        int verticalSpeed = 4;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;

        Message pause;
        GameBase gameBase;
        Random cambio = new Random();
        Panel Tela;

        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.MountainTrials);
        int canPlaying = 0;


        public GameScreen(Panel panel, GameBase gBase)
        {
            InitializeComponent();
            Tela = panel;
            gameBase = gBase;
            pause = new Message(this, gameBase, Tela);
        }

        #region Relogio:
        //Relógio do jogo:
        private void FPS_Tick(object sender, EventArgs e)
        {
            if ( canPlaying == 0)
            {
                //soundPlayer = new SoundPlayer(Properties.Resources.MountainTrials);
                soundPlayer.PlayLooping();

                canPlaying = 1;
            }


            txtScore.Text = "Pontos: " + score; //Atualizando placar;

            this.Player.Top += jumpSpeed;


            if (goLeft && this.Player.Location.X > 4)
            {
                this.Player.Left -= playerSpeed;
            }

            if (goRight && this.Player.Location.X < 555)
            {
                this.Player.Left += playerSpeed;
            }

            if (jumping && force <0)
            {

                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            //Interagindo:
            foreach (Control control in this.Controls)
            {
                
                if (control is PictureBox)
                {
                    //Impedindo de cair pelo chão:
                    if ((string)control.Tag == "platform")
                    {
                        if (Player.Bounds.IntersectsWith(control.Bounds))
                        {
                            force = 8;
                            Player.Top = control.Top - Player.Height;

                            //Andando sozinho com a plataforma horizontal:
                            if ( (string)control.Name == "horizontalPlatform" && (!goLeft || !goRight) )
                            {
                                Player.Left -= horizontalSpeed;
                            }

                        }

                        control.BringToFront();
                    }

                    //Pegando as moedas:
                    if ( (string)control.Tag == "coin" )
                    {
                        if (Player.Bounds.IntersectsWith(control.Bounds) && control.Visible == true)
                        {
                            control.Visible = false;
                            
                            score += cambio.Next(1, 50);

                        }
                    }
                        
                    //Enconstando nos inimigos:
                    if ( (string)control.Tag == "enemy" )
                    {
                        if (Player.Bounds.IntersectsWith(control.Bounds))
                        {
                            soundPlayer.Stop();
                            FPS.Stop();
                            isGameOver = true; 

                            pause = new Message(this, gameBase, Tela, score, "Em Chagas.");
                            pause.btnContinue.Visible = false;
                            pause.ShowDialog();

                            this.txtScore.Text = "Pontos: " + score /*+ "\nVocê falhou em sua jornada."*/;
                        }
                    }
                }
            }

            //Plataformas que se movimentam:

            horizontalPlatform.Left -= horizontalSpeed; //Movendo a Plataforma da Horizontal:
            //Trocando a direção, invertendo o sinal da velocidade:
            if (horizontalPlatform.Left < 0 || horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            verticalPlatform.Top -= verticalSpeed; //Movendo a Plataforma da Vertical:
            //Ou mais simples:
            //                    < Cima >                    < Baixo >    
            if (verticalPlatform.Top < 250|| verticalPlatform.Top > 560)
            {
                verticalSpeed = -verticalSpeed;
            }


            //Inimigos:
            enemyOne.Left -= enemyOneSpeed;
            if ( enemyOne.Left-5 < pictureBox3.Left || enemyOne.Left+enemyOne.Width+5 > pictureBox3.Right)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            enemyTwo.Left -= enemyTwoSpeed;
            if (enemyTwo.Left - 5 < pictureBox1.Left || enemyTwo.Left + enemyTwo.Width + 5 > pictureBox1.Right)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }


            //GameOver por cair para baixo do cenário:
            if ( Player.Top+Player.Height > this.ClientSize.Height +50 )
            {
                soundPlayer.Stop();
                FPS.Stop();
                isGameOver = true;

                pause = new Message(this, gameBase, Tela, score, "Aos Ares.");
                pause.btnContinue.Visible = false;
                pause.ShowDialog();
            }

            //Passando pelo portal:
            if ( Player.Bounds.IntersectsWith(Portal.Bounds) )
            {
                soundPlayer.Stop();
                FPS.Stop();
                this.Player.Visible = false;
                isGameOver = true;

                pause = new Message(this, gameBase, Tela, "Sucesso!", score);
                pause.btnContinue.Visible = false;
                pause.ShowDialog();
            }

        }

        #endregion Fim do Relogio


        #region Teclado e Movimentação:

        bool canChangeToRight = false; //Controlar se a imagem pode mudar de eixo ou nao;

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            Bitmap bitplayer = (Bitmap)this.Player.Image; //Pegando a imagem do nosso boneca;

            if (e.KeyCode == Keys.A) //Indo para esquerda;
            {
                goLeft = true;

                if (canChangeToRight == false)
                {
                    bitplayer.RotateFlip(RotateFlipType.Rotate180FlipY); //Trocando a direção da imagem;
                }

                canChangeToRight = true; //Impede de trocar a virar a imagem na posição errada;
            }

            if (e.KeyCode == Keys.D) //Indo para direita;
            {
                goRight = true;

                if (canChangeToRight == true)
                {
                    bitplayer.RotateFlip(RotateFlipType.Rotate180FlipY); //Trocando a direção da imagem;
                }

                canChangeToRight = false; //Impede de trocar a virar a imagem na posição errada;
            }

            //Usando Espaço ou W:
            if ( (e.KeyCode == Keys.Space || e.KeyCode == Keys.W) && jumping == false) //Pulando;
            {
                jumping = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A) 
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.D) 
            {
                goRight = false;
            }

            if (jumping)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.Escape && !isGameOver)
            {
                soundPlayer.Stop();

                this.FPS.Enabled = false;
                pause.ShowDialog();

                canPlaying = 0;
            }


        }

        #endregion Fim;


        #region Recomeçando o Jogo:

        //Função para reiniciar o jogo:
        internal void RestartGame()
        {
            //Resetando as variáveis necessárias:
            soundPlayer.PlayLooping();

            jumping = false;
            goRight = false;
            goLeft = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Pontos: " + score;

            pause = new Message(this, gameBase, Tela);

            //Pegando as moedas e as deixando vísiveis novamente:
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Visible == false)
                {
                    control.Visible = true;
                }

            }

            //Resetando a posição do jogador, inimigos e plataformas:
            this.Player.Left = 28;  //X
            this.Player.Top = 561;  //Y

            this.enemyOne.Left = 382;
            ///this.enemyOne.Top = 262;

            this.enemyTwo.Left = 352;
            //this.enemyTwo.Top = 479;

            this.horizontalPlatform.Left = 180;  //X pois se movimenta na horizontal;
            this.verticalPlatform.Top = 468;     //Y pois se movimenta na vertical;

            if (canChangeToRight)
            {
                Bitmap bitplayer = (Bitmap)this.Player.Image; //Pegando a imagem do nosso boneca;
                bitplayer.RotateFlip(RotateFlipType.Rotate180FlipY); //Trocando a direção da imagem;
                canChangeToRight = false; // Não pode virar a imagem pra direira já que ele começa na direita;
            }

            this.FPS.Start();
        }

        #endregion Fim Função.

    }
}
