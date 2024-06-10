using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWatch;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            this.labelCronometro.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch.Elapsed);
            //this.labelCronometro.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}
