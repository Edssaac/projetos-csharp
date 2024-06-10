using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContagemRegressiva
{
    public partial class Form1 : Form
    {
        private int totalDeSegundos;

        public Form1()
        {
            InitializeComponent();

            btnParar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int n = 0; n < 60; n++)
            {
                this.comboMinutos.Items.Add(n.ToString());
                this.comboSegundos.Items.Add(n.ToString());
            }

            this.comboMinutos.SelectedIndex = 59;
            this.comboSegundos.SelectedIndex = 59;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            btnParar.Enabled = true;

            int minutos = int.Parse(comboMinutos.Text);
            int segundos = int.Parse(comboSegundos.Text);

            totalDeSegundos = (minutos * 60) + segundos;

            this.Timer.Enabled = true;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            btnParar.Enabled = false;
            btnIniciar.Enabled = true;

            this.Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (totalDeSegundos > 0)
            {
                int minutos = totalDeSegundos / 60;
                int segundos = totalDeSegundos - (minutos*60);

                this.labelTempo.Text = minutos + ":" + segundos;

                totalDeSegundos--;
            }
            else
            {
                this.Timer.Enabled = false;
                MessageBox.Show("Acabou o Tempo!");
            }

        }
    }
}
