using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;        //for stream object
using System.Reflection;        // for assembly
namespace Joud_Applecation
{
    public partial class frmImage : Form
    {

        Assembly _assembly;
        Stream _imagestream;
        public frmImage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\جود\\Desktop\\IMG_0455.PNG");
            }
            catch 
            {

                MessageBox.Show("image file not found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Image = Image.FromStream(_imagestream);
            }
            catch 
            {
                MessageBox.Show("error creating image form resourses");
                
            }
        }

        private void frmImage_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imagestream = _assembly.GetManifestResourceStream("Joud_Applecation.res.a.jpg");
        }
    }
}
