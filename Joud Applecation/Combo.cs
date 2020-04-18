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
    public partial class Combo : Form
    {
        public Combo()
        {
            InitializeComponent();

            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuseday");
            comboBox1.Items.Add("Wednesday");
            comboBox1.Items.Add("Thursday");
            comboBox1.Items.Add("Friday");
            comboBox1.Items.Add("Saturday");
            comboBox1.Items.Add("Funday");
            comboBox1.Items.Add("Examday");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                       




        }

        private void Combo_Load(object sender, EventArgs e)
        {

        }

        private void slcMethod1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);

        }

        private void slcMethod2_Click(object sender, EventArgs e)
        {
            string itemText = comboBox1.GetItemText(comboBox1.SelectedItem);
            MessageBox.Show(itemText);
        }

        private void Metod3_Click(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem;
            MessageBox.Show(item.ToString());
        }

        private void RemoveName_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove("Friday");
        }

        private void RemoveIndex_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(1);
            // this will remove the iteam number 2 beacus the 
            //computer always starts at 0


            //namespace >>class>>Method
            //every method have a counstrucror 
            // counstrucror is a spical kind of method 
        }

        private void removeLast_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count >= 1)
            {
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("there is nothing chosin yet");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
