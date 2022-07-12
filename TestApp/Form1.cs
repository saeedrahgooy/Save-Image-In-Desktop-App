using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "mage Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            //var path = @"C:\Users\baabiran\Desktop\DotNet\TestApp\TestApp\Images";
            op.ShowDialog();
            try
            {
                File.Copy(op.FileName,Path.Combine(@"C:\Users\baabiran\Desktop\DotNet\TestApp\TestApp\Images\",Path.GetFileName(op.FileName)),true);
                MessageBox.Show("upload image successfully");
            }
            catch (Exception ex) {

                label1.Text = ex.Message;
            }
            
        }
    }
}
