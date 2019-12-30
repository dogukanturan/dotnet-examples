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
    public partial class dictionary : Form
    {
        public dictionary()
        {
            InitializeComponent();
        }

        string path = @"C:\Users\dturan\Desktop\Görsel 1 Final\görsel-dosya";
        private void button1_Click(object sender, EventArgs e)
        {
            //butona tıklandığında konumdaki docx'lerin isimlerini listbox'a ekleyen kod...
            listBox1.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles();
            foreach(var item in fi)
            {
                if(item.Extension == ".docx")
                    listBox1.Items.Add(item.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dizindeki .pdf'leri richtextboxa aktaran kod...
            richTextBox1.Clear();

            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles();
            foreach (var item in fi)
            {
                if (item.Extension == ".pdf")
                    richTextBox1.AppendText(item.Name + "\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Dizinde baş harfi m ile başlayanları listbox'a ekleyen kod...

            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles();
            foreach(var item in fi)
            {
                if (item.Name.Substring(0,1) == "m" || item.Name.Substring(0,1) == "M")
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }
    }
}
