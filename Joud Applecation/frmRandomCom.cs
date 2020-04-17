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
    public partial class frmRandomCom : Form
    {
        public frmRandomCom()
        {
            InitializeComponent();
        }

        private void btngen1_Click(object sender, EventArgs e)
        {
            btngen1.ResetText();       
               
            Random r = new Random();
            {
                

                    
            }
        }
       

        private void btnre1_Click(object sender, EventArgs e)
        {
            randomcombox1.ResetText();
            randomcombox1.Items.Clear();

           
        }
        private void randomcombox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(randomcombox1.Text) > 499)
            {
             
            }
            else
            {
               
            }

        }

        private void randomcombox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngen2_Click(object sender, EventArgs e)
        {
            btngen2.ResetText();
            
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                
            }
          
    }
    }
}
