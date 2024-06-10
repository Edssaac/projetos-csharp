using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Sharpth
{

    public partial class MenuMessage : Form
    {
        public MenuMessage(int x, int y, string ctx)
        {
            InitializeComponent();

            this.Location = new Point( (x/2)+225, (y/2)-70);


            if (ctx == "ins")
                this.picHolder.Image = Properties.Resources.picInstructions;

            else if (ctx == "creds")
                this.picHolder.Image = Properties.Resources.picCredits;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
