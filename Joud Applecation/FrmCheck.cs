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
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (chkCfi.Checked == true)
            {
                msg = chkCfi.Text;

            }
            if (chkDnt.Checked == true)
            {
                msg = msg + "  " + chkDnt.Text;
            }
            if (chkbrni.Checked == true)
            {
                msg = msg + "  " + chkbrni.Text;
            }
            if (msg.Length>0)
            {
                MessageBox.Show(msg + " Orderd");
            }
            else
            {
                MessageBox.Show("nothing is Orderd");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
