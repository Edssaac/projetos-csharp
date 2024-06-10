using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.maskedTextBox1.Clear();
            this.maskedTextBox2.Clear();

            this.textBox1.Clear();
            this.textBox2.Clear();

            this.maskedTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double imc;

            if ( double.TryParse(maskedTextBox1.Text, out imc) && double.TryParse(maskedTextBox2.Text, out imc))
            {
                imc = Convert.ToDouble(maskedTextBox1.Text) / Math.Pow(Convert.ToDouble(maskedTextBox2.Text), 2);
                this.textBox1.Text = imc.ToString("00.00");

                if (imc >= 40.0)
                    this.textBox2.Text = "Obesidade Mórbida (Grau III)";
                else if (imc >= 35.0 && imc <= 39.9)
                    this.textBox2.Text = "Obesidade Severa (Grau II)";
                else if (imc >= 30.0 && imc <= 34.9)
                    this.textBox2.Text = "Obesidade (Grau I)";
                else if (imc >= 25.0 && imc <= 29.9)
                    this.textBox2.Text = "Sobrepeso";
                else if (imc >= 18.5 && imc <= 24.9)
                    this.textBox2.Text = "Peso Normal";
                else
                    this.textBox2.Text = "Peso Baixo";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Focus();
            string stringona="Insira os dados e após o cálculo clique aqui\n" +
                             "para receber informações sobre sua classificação.";

            switch (textBox2.Text)
            {
                case ("Peso Baixo"):
                    stringona = "O que pode acontecer:\n\n" +
                        "Queda de cabelo, infertilidade, ausência menstrual, fadiga, stress, ansiedade.";
                    break;
                case ("Peso Normal"):
                    stringona = "O que pode acontecer:\n\n" +
                        "Menor risco de doenças cardíacas e vasculares.";
                    break;
                case ("Sobrepeso"):
                    stringona = "O que pode acontecer:\n\n" +
                        "Fadiga, má circulação, varizes.";
                    break;
                case ("Obesidade (Grau I)"):
                    stringona = "O que pode acontecer:\n\n" +
                        "Diabetes, angina, infarto, aterosclerose.";
                    break;
                case ("Obesidade Severa (Grau II)"):
                    stringona = "O que pode acontecer:\n\n" +
                        "Apneia do sono, falta de ar.";
                    break;
                case ("Obesidade Mórbida (Grau III)"):
                    stringona = "O que pode acontecer:\n\n" +
                        "Refluxo, dificuldade para se mover, escaras, diabetes, infarto, AVC.";
                    break;
            }

            MessageBox.Show(stringona, textBox2.Text);
        }
    }
}
