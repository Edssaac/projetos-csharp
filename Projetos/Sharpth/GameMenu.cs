using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using System.Media;

namespace Sharpth
{
    public partial class GameMenu : Form
    {
        GameBase gameBase;
        MenuMessage menuMessage;
        Panel Tela;
        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.JackStauberButtercup);


        public GameMenu(GameBase gameBase, Panel panel)
        {
            InitializeComponent();
            this.gameBase = gameBase; //Instanciando o formulario principal;
            Tela = panel;
            
            soundPlayer.PlayLooping(); //Iniciando a musica em loop;
        }

        public GameMenu()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen(Tela, gameBase) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Tela.Controls.Add(gameScreen);
            soundPlayer.Stop(); //Parando a musica;
            this.Visible = false; //Ocultando o menu;
            gameScreen.Show(); //Chamando o Jogo;
            this.Close(); //Fechando o Menu;
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            menuMessage = new MenuMessage(ClientSize.Width, ClientSize.Height, "ins");
            menuMessage.ShowDialog();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            menuMessage = new MenuMessage(ClientSize.Width, ClientSize.Height, "creds");
            menuMessage.ShowDialog();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            gameBase.Close(); // Saindo da aplicação;
        }


    }
}
