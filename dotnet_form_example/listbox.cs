using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_form_example
{
    public partial class listbox : Form
    {
        public listbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listbox1 ve listbox2 3-10 arasında bir boyutta random sayı ile dolduruldu.
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            Random r = new Random();
            int random_number = r.Next(3, 10);
            for (int i = 0; i < random_number; i++)
            {
                listBox1.Items.Add(r.Next(1, 30));
            }
            random_number = r.Next(3, 10);
            for (int i = 0; i < random_number; i++)
            {
                listBox2.Items.Add(r.Next(1, 30));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listbox1 ve listbox2'nin kesişimi.           
            listBox3.Items.Clear();
            
            foreach(var item in listBox1.Items)
            {
                if (listBox2.Items.Contains(item))
                    listBox3.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //lb1 fark lb2        
            listBox3.Items.Clear();
            
            foreach (var item in listBox1.Items)
            {
                if (!listBox2.Items.Contains(item))
                    listBox3.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //lb1 ve lb2 deki elemanları lb3'e aktaran kod (aynı değere sahip olanlar 1 kere yazıldı)  
            listBox3.Items.Clear();

            foreach (var item in listBox1.Items)
                listBox3.Items.Add(item);

            for(int i = 0; i < listBox2.Items.Count; i++)
            {
                if (!listBox3.Items.Contains(listBox2.Items[i]))
                    listBox3.Items.Add(listBox2.Items[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            ListBox list = new ListBox();
            for (int i = listBox3.Items.Count - 1; i >= 0; i--)
                list.Items.Add(listBox3.Items[i]);
            listBox3.Items.Clear();
            foreach (var item in list.Items)
                listBox3.Items.Add(item);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] dizi = { "Sivas", "Cumhuriyet", "Üniversitesi", "Yönetim Bilişim Sistemleri" };
            for (int i = 0; i < dizi.Length; i++)
                listBox3.Items.Add(dizi[i].ToString());
        }
    }
}