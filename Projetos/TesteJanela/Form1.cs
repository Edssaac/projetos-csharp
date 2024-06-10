using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool mover = false;
        Point posicao;

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {

            if (mover)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - posicao.X, p.Y - posicao.Y );
            }

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
    }
}
