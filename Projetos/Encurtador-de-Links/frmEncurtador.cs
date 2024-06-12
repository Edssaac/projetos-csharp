using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace Bitly
{
    public partial class frmEncurtador : Form
    {
        public frmEncurtador()
        {
            InitializeComponent();
        }


        //Fechando a Aplicação:
        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Minimizando a Aplicação:
        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Variveis necessárias para mover a janela:
        bool movendo = false; //Não começamos nos movendo;
        Point movimento;

        //Ao clicar no componente:
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            movendo = true; //Estamos nos movendo;
            movimento = new Point(e.X, e.Y); //Pegando a posição clicada no Panel;
        }
        //Ao mover o componente:
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if ( movendo ) //Estamos nos movendo?
            {
                Point p = PointToScreen(e.Location); //Pegando a posição da tela;
                this.Location = new Point(p.X - movimento.X, p.Y - movimento.Y);
                //Posição da Tela - Posição do Panel = Nova Posição; 
            }
        }
        //Ao parar de interagir com o componente:
        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            movendo = false; //Não estamos nos movendo!
        }



        //Função Assíncrona:
        private async void btnEncurtar_Click(object sender, EventArgs e)
        {
            //Limpando o campo de URL Encurtada:
            txtURLEncuratada.Clear();

            //Se o campo estiver vazio então não fazemos nada.
            if ( txtURL.Text.Trim().Equals(string.Empty) )
            {
                return; 
            }


            //Pegando a string (url longa) e removendo os espaços na frente e atrás se existentes:
            string longURL = txtURL.Text.Trim();

            //Verificando se está com "https://":
            if ( longURL.IndexOf("https://") == -1 )
            {
                longURL = "https://" + longURL; 
            }

            //Instânciando nossa API:
            BitlyAPI.BitlyAPI api = new BitlyAPI.BitlyAPI();

            //Esperando para passar o link encurtado para o usuário:
            string result = await api.ShortenAsync(longURL);

            //Verificando se o retorno é válido:
            if ( result == "INVALID_URI" )
                MessageBox.Show("Verifique se a URL está correta \ne se está no formato \"https://\"", 
                                "Problema ao tentar converter",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            else if ( result == "INVALID_ACCESS_TOKEN")
                MessageBox.Show("Verifique se o Token do Bitly está incorreto \nou se está em branco.", 
                                "Bitly Token - Incorreto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            else
                txtURLEncuratada.Text = result;

        }

        //Sempre que usarmos uma função assincrona, o método deve receber async também:
        private async void btnEncurtarLista_Click(object sender, EventArgs e)
        {
            string strEntrada = @"Caminho absoluto de seu arquivo de Entrada.txt"; //Arquivo de Entrada;
            string strSaida = @"Caminho absoluto de seu arquivo de Saida.txt";     //Arquivo de Saída;

            //O arquivo de entrada existe?
            if (File.Exists(strEntrada))
            {
                //Então lemos ele:
                using (StreamReader sr = new StreamReader(strEntrada))
                {
                    var listLinks = new List<Link>(); //Uma lista para os links;
                    string linha = string.Empty; //Receberá cada linha do arquivo de entrada;

                    //Enquanto houverem linhas:
                    while ( (linha = sr.ReadLine()) != null)
                    {
                        var oLink = new Link(); //Objeto que receberá um link por vez;

                        oLink.LongUrl = linha; //Passando o link atual;

                        listLinks.Add(oLink); //Adicionando o novo link para a lista;
                    }

                    //Instânciando nossa API:
                    BitlyAPI.BitlyAPI api = new BitlyAPI.BitlyAPI();

                    //Encurtando cada um dos links registrados:
                    foreach (var link in listLinks)
                    {
                        //Encurtando os links de seus respectivos conjuntos: 
                        link.ShortUrl = await api.ShortenAsync(link.LongUrl);
                    }

                    //Escrevendo nossos links encurtados no nosso arquivo de saída:
                    using (StreamWriter sw = new StreamWriter(strSaida, false)) //o false limpa o arquivo e depois adiciona o novo conteúdo,
                    {                                                           //se fosse true o conteúdo seria adicionado após o que já existia.
                        //Trabalhando com cada um dos links encurtados: 
                        foreach (var link in listLinks)
                        {
                            sw.WriteLine(link.ShortUrl); //Escrevendo cada um deles;
                        } 
                    }

                }

                MessageBox.Show("Processamento Finalizado!");

            }
        }
    }
}
