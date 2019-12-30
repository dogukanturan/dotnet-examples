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
    
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listbox listbox = new listbox();
            listbox.ShowDialog();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkbox checkbox = new checkbox();
            checkbox.ShowDialog();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treenode tn = new treenode();
            tn.ShowDialog();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            readerwriter srwr = new readerwriter();
            srwr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richtextbox rtb = new richtextbox();
            rtb.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dictionary dc = new dictionary();
            dc.ShowDialog();
        }

    }
}
