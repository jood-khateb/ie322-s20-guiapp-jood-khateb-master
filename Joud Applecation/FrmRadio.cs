using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joud_Applecation
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void RadRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRed.Checked ==true)
            {
                RadRed.ForeColor = Color.FromArgb(255, 0, 0); 
            }
            else
            {
                RadRed.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void radGrn_CheckedChanged(object sender, EventArgs e)
        {
            if (radGrn.Checked == true)
            {
                radGrn.ForeColor = Color.FromName("Green");
            }
            else
            {
                radGrn.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void RadBlu_CheckedChanged(object sender, EventArgs e)
        {

            if (RadBlu.Checked == true)
            {
                RadBlu.ForeColor = Color.FromName("blue");
            }
            else
            {


                RadBlu.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
        

        private void RadYlw_CheckedChanged(object sender, EventArgs e)
        {
            if (RadYlw.Checked==true)
            {
                RadYlw.ForeColor = Color.FromName("yellow"); 
            }
            else
            {
                RadYlw.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RadRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRed2.Checked == true)
            {
                RadRed2.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                RadRed2.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void RadGrn2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadGrn2.Checked == true)
            {
                RadGrn2.ForeColor = Color.FromName("green");
            }
            else
            {
                RadGrn2.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void RadBlu2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBlu2.Checked == true)
            {
                RadBlu2.ForeColor = Color.FromName("Blue");
            }
            else
            {
                RadBlu2.ForeColor = Color.FromArgb(0, 0, 0);
            }


        }

        private void RadYlw2_CheckedChanged(object sender, EventArgs e)
        {
            if(RadYlw2.Checked==true)
            {
                RadYlw2.ForeColor = Color.FromName("Yellow");
            }
            else
            {
                RadYlw2.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
    }
}
