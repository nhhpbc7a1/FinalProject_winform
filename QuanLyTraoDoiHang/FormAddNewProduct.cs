using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class FormAddNewProduct : Form
    {
        public FormAddNewProduct()
        {
            InitializeComponent();
        }

        private void btnChangePicture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                picboxProduct.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                picboxProduct.Refresh(); 
                textBox1.Text = System.IO.Directory.GetCurrentDirectory();
                textBox2.Text = openFileDialog1.FileName;
            }

        }
    }
}
