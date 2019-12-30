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

namespace dotnet_form_example
{
    public partial class treenode : Form
    {
        public treenode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richtextbox'daki kelimeleri treenode'a aktran kod...

            treeView1.Nodes.Clear();
            for(int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                string[] satir = richTextBox1.Lines[i].Split(',');
                TreeNode tn = treeView1.Nodes.Add(satir[0]);
                for (int j = 1; j < satir.Length; j++) //1'den başlaması önemli...
                    tn.Nodes.Add(satir[j]);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ülkeler.txt belgesindeki ülkeler ve şehirleri treenode'a ekleyen kod...

            treeView1.Nodes.Clear();
            StreamReader sr = new StreamReader("ülkeler.txt");
            while (!sr.EndOfStream)
            {
                string[] metin = sr.ReadLine().Split(',');
                TreeNode tn = treeView1.Nodes.Add(metin[0]);
                for (int i = 1; i < metin.Length; i++)
                    tn.Nodes.Add(metin[i]);
            }
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //checbox seçili ise seçili değilse seçili değil yazan kod...

            treeView1.Nodes.Clear();
            foreach (var item in this.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cbox = (CheckBox)item;
                    TreeNode tn = treeView1.Nodes.Add(cbox.Text);
                    if (cbox.Checked)
                        tn.Nodes.Add("Seçili");
                    else
                        tn.Nodes.Add("Seçili Değil");
                }
            }
            treeView1.ExpandAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (TreeNode item in treeView1.Nodes)
            {
                richTextBox2.SelectedText = (item.Text+"\n");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //treeview çarpım tablosu...

            for(int i = 1; i <= 10; i++)
            {
                TreeNode carpim = treeView1.Nodes.Add(i.ToString());
                for (int j = 1; j <= 10; j++)
                    carpim.Nodes.Add(string.Format("{0} X {1} = {2}", i, j, i * j));
            }
            treeView1.ExpandAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Treeview üzerindeki item'ları .txt dosyasına yazan program...

            StreamWriter sw = new StreamWriter("deneme-writer.txt", true, Encoding.UTF8);
            foreach(TreeNode dugum in treeView1.Nodes)
            {
                sw.WriteLine(dugum);
                foreach (TreeNode alt_dugum in dugum.Nodes)
                {
                    sw.WriteLine(alt_dugum.Text);
                }
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
