using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool direita = true;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            #region CimaBaixo
            /*
            if (e.KeyChar.ToString() == "w" || e.KeyChar.ToString() == "W")
            {   //Cima:
                this.personagem.Location = new Point(personagem.Location.X, personagem.Location.Y-90);

                while (personagem.Location.Y < 245)
                {
                    Task.Delay(1);
                    this.personagem.Location = new Point(personagem.Location.X, personagem.Location.Y + 1);
                }

            }

            if (e.KeyChar.ToString() == "s" || e.KeyChar.ToString() == "S")
            {   //Baixo:
                //this.personagem.Location = new Point(personagem.Location.X, personagem.Location.Y+3);
            }
            */
            #endregion

            Bitmap bitpersonagem = (Bitmap) this.personagem.Image;

            if (e.KeyChar.ToString() == "a" || e.KeyChar.ToString() == "A")
            {   //Esquerda:

                if (direita)
                {
                    bitpersonagem.RotateFlip(RotateFlipType.Rotate180FlipY);
                    this.personagem.Image = bitpersonagem;

                    direita = false;
                }

                if (personagem.Location.X > 3)
                {
                    this.personagem.Location = new Point(personagem.Location.X-10, personagem.Location.Y);
                }
            }

            if (e.KeyChar.ToString() == "d" || e.KeyChar.ToString() == "D")
            {   //Direita:

                if (!direita)
                {
                    bitpersonagem.RotateFlip(RotateFlipType.Rotate180FlipY);
                    this.personagem.Image = bitpersonagem;

                    direita = true;
                }

                if (personagem.Location.X < 710)
                {
                    this.personagem.Location = new Point(personagem.Location.X + 10, personagem.Location.Y);
                }
            }

        }




    }
}
