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
using System.Threading;
using System.Text.RegularExpressions;


namespace Rejest_licznika_V2
{

    
    public partial class Main_form : Form
    {
        string openedfile;

        FileStream fs;

        public Main_form()
    {
            InitializeComponent();

        }

    private void add_Click(object sender, EventArgs e)
    {
            
            
            using (fs = new FileStream(openedfile, FileMode.Append, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(textBox1.Text.ToString() + "\t\t" + textBox2.Text.ToString() + " km" + "\t\t" + textBox3.Text.ToString());
                sw.Dispose();
            }

        refresh.Enabled = true;
        textBox1.Clear();
        textBox2.Clear();
        textBox3.Clear();
        listBox1.Items.Clear();
    }

    private void clear_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
        textBox2.Clear();
        textBox3.Clear();
    }

    private void refresh_Click(object sender, EventArgs e)

    {


            using (FileStream fr = new FileStream(openedfile, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fr);
                string text = sr.ReadToEnd();
                string[] lines = text.Split('\r');
                foreach (string s in lines)
                {
                    listBox1.Items.Add(s);
                }
                refresh.Enabled = false;
            }
    }

        private void load_file_Click(object sender, EventArgs e)
        {
            Main_form mf = new Main_form();
            openFileDialog1.InitialDirectory = @"C:\Users\dwiad\Desktop\Visual 2015\Rejest licznika V2\Rejest licznika V2\bin\Debug";

            openFileDialog1.Filter = "Pliki tekstowe(txt)|*.txt";

            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openedfile = openFileDialog1.SafeFileName;
                toolStripStatusLabel1.Text = "Wczytany plik: " + openedfile;
            }
        }

        private void add_new_file_Click(object sender, EventArgs e)
        {
            add_file adf = new add_file();
            this.Hide();
            adf.Show();
        }

        private void Main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
