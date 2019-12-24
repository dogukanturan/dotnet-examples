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
    public partial class checkbox : Form
    {
        public checkbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checked olanları listbox'a ekleyen kod...

            listBox1.Items.Clear();
            foreach(Control c in this.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox cbox = (CheckBox)c;
                    if (cbox.Checked)
                        listBox1.Items.Add(cbox.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Baş Harfi İ olanları listbox'a aktaran kod.

            listBox1.Items.Clear();
            foreach(var item in this.Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox cbox = (CheckBox)item;
                    if (cbox.Text.Substring(0,1) == "İ")
                        listBox1.Items.Add(cbox.Text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Checked olanlardan baş harfi i ile başlayanları listbox'a aktaran kod...

            listBox1.Items.Clear();
            foreach(var item in this.Controls)
                if(item is CheckBox)
                {
                    CheckBox cbox = (CheckBox)item;
                    if (cbox.Checked && cbox.Text.Substring(0, 1) == "İ")
                        listBox1.Items.Add(cbox.Text);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //checked olanı silen kod...

            foreach(var item in this.Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox cbox = (CheckBox)item;
                    if (cbox.Checked)
                        this.Controls.Remove(cbox);
                }
            }
        }
    }
}
