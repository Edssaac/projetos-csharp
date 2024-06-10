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

namespace Texter
{
    public partial class TexterDetalhes : Form
    {
        Form f;

        public TexterDetalhes(Form1 f1)
        {
            InitializeComponent();

            f = f1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://edssaac.github.io/portfolio/");
        }

        private void TexterDetalhes_Load(object sender, EventArgs e)
        {

        }

        private void TexterDetalhes_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Enabled = true; //Reativa a outra janela;
        }
    }
}
