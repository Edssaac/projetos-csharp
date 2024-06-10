using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Drawing;
using System.Windows.Forms;

namespace Sharpth
{
    public partial class GameBase : Form
    {
        public GameBase()
        {
            InitializeComponent();

            //Chamando nosso menu:
            GameMenu gameMenu = new GameMenu(this, panelShowing) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShowing.Controls.Add(gameMenu);
            gameMenu.Show();
        }


        #region Barra Superior:
        //Variaveis para a movimentação da janela:
        bool mover; //Pode mover?
        Point posJanela;  //Recberá a posição atual da janela;

        private void panelTop_MouseDown(object sender, MouseEventArgs e) //Quando for clicado:
        {
            mover = true; //Pode mover;
            posJanela = new Point(e.X, e.Y); //Recebendo atual posição;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e) //Enquanto o click está pressionado:
        {
            if (mover)
            {
                Point p = PointToScreen(e.Location); //Pega o ponto em que foi clicado;
                this.Location = new Point(p.X-posJanela.X, p.Y-posJanela.Y); //Movimentando a janela;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e) //Quando parar de clicar:
        {
            mover = false; //Não pode mais mover;
        }


        //Minimizando e Fechando:
        private void picMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
