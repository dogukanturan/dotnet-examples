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

namespace dotnet_form_example
{
    public partial class readerwriter : Form
    {
        public readerwriter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deneme.txt to richtextbox...

            StreamReader sr = new StreamReader("deneme.txt");
            while (!sr.EndOfStream)
            {
                string[] metin = sr.ReadLine().Split(',');
                for(int i = 0; i < metin.Length; i++)
                {
                    richTextBox1.SelectedText = metin[i] + " ";
                }
            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //deneme.txt to listbox...

            StreamReader sr = new StreamReader("deneme.txt");
            while (!sr.EndOfStream)
            {
                string[] metin = sr.ReadLine().Split(',');
                for (int i = 0; i < metin.Length; i++)
                {
                    listBox1.Items.Add(metin[i]);
                }
            }
            sr.Close();
        }
    }
}
