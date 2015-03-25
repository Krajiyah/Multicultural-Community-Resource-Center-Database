using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Horran_Appartments_Database
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("temp.txt");
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception f)
            {
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temp.txt", false);
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }
            catch (Exception d)
            {
            }
        }
    }
}
