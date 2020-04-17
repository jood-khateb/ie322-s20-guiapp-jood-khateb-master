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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void LogBtn_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "Jood" && txtPw.Text == "1234")
            {
                MessageBox.Show("Login Succsiful");


            }
            else
            {
                MessageBox.Show("Invalid  Password or Username");
            }
        }

        private void RadBtn_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();

        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {

        }

        private void ChkBtn_Click(object sender, EventArgs e)
        {
            FrmCheck frm = new FrmCheck();
            frm.ShowDialog();
        }

        private void CmboBtn_Click(object sender, EventArgs e)
        {
            Combo frm = new Combo();
            frm.ShowDialog();
        }

        private void RanBtn_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void PicBtn_Click(object sender, EventArgs e)
        {
            frmImage frm = new frmImage();
            frm.ShowDialog();
        }

        private void RancBtn_Click(object sender, EventArgs e)
        {
            frmRandomCom frm = new frmRandomCom();
            frm.ShowDialog();
        }
    }
}
