using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Random;

namespace Joud_Applecation
{
    public partial class frmRandom : Form
    {
        Random y = new Random();
        public frmRandom()
        {
           
            InitializeComponent();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           


            button2.Text = Convert.ToString (y.Next(1, 100));
        }
    }
}
