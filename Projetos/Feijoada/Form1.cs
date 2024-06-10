using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feijoada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello WOrld! :)");

            label1.ForeColor = Color.Black;

            this.Text = textBox1.Text;

            trackBar1.Value = 0;
            progressBar1.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 30;


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
            //label1.Text = trackBar1.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value >= 50)
                this.timer1.Enabled = false;
            else
                progressBar1.Value++;
        }
    }
}
