using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using System.Media;

namespace Sharpth
{
    public partial class Message : Form
    {
        GameScreen gameScreen;
        GameBase gameBase;
        Panel Tela;
        SoundPlayer soundPlayer;
        private string Ctx = null;

        //Pausa:
        public Message(GameScreen frm, GameBase gBase, Panel panel)
        {
            InitializeComponent();
            gameScreen = frm;
            gameBase = gBase;
            Tela = panel;
        }

        //Mortes:
        public Message(GameScreen frm, GameBase gBase, Panel panel, int score, string ctx)
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer(Properties.Resources.LunarDragonSong);
            soundPlayer.PlayLooping();

            this.labelText.Text = ctx;
            this.labelText.Left = (ClientSize.Width - labelText.Width) / 2;
            this.labelUnderline.Left = (ClientSize.Width - labelUnderline.Width) / 2;
            this.txtScore.Text = "Pontuação: " + score;
            gameScreen = frm;
            gameBase = gBase;
            Tela = panel;
            Ctx = ctx;
        }

        //Vitoria:
        public Message(GameScreen frm, GameBase gBase, Panel panel, string ctx, int score)
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer(Properties.Resources.VictoryTheme);
            soundPlayer.PlayLooping();


            this.labelText.Left = (ClientSize.Width - labelText.Width) / 2;
            this.labelUnderline.Left = (Width - labelUnderline.Width) / 2;
            this.labelText.Text = ctx;
            this.txtScore.Text = "Pontuação: " + score;
            gameScreen = frm;
            gameBase = gBase;
            Tela = panel;
            Ctx = ctx;
        }


        //Verificando se esc foi apertado na pausa para assim poder despausar:
        private void Message_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape  && Ctx == null)
            {
                gameScreen.FPS.Enabled = true;
                this.Close();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            gameScreen.FPS.Enabled = true;
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Ctx))
                soundPlayer.Stop();


            gameScreen.RestartGame();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Ctx))
                soundPlayer.Stop();

            GameMenu gameMenu = new GameMenu(gameBase, Tela) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Tela.Controls.Add(gameMenu);
            gameMenu.Show();

            this.Close();
            gameScreen.Close();

        }


    }


}
