using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rejest_licznika_V2
{
    public partial class add_file : Form
    {
        Main_form mf = new Main_form();
        public add_file()
        {

            InitializeComponent();
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(textBox1.Text + ".txt");
            
            //string dir = @"C:\Users\dwiad\Desktop\Visual 2015\Rejest licznika V2\Rejest licznika V2\bin\Debug\pliki";
            if (!string.IsNullOrEmpty(textBox1.Text) )
                {

                file.Create().Close();
                MessageBox.Show("File is created");
               
            }



            this.Close();
            mf.Show();
            
            
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
            
            

        }

        private void add_file_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            mf.Show();
        }
    }
}
