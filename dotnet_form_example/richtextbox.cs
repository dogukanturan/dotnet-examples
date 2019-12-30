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
    public partial class richtextbox : Form
    {
        public richtextbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\Dosyalarım\Pictures\Wallpaper\Space";
            ofd.Filter = "Tüm Dosyalar|*.*|; Resim Dosyaları|*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in ofd.FileNames)
                {
                    int sirasi = item.IndexOf(',');
                    string uzanti = item.Substring(sirasi + 1);
                    if(uzanti == "jpg" || uzanti == "bmp")
                    {
                        Image img = Image.FromFile(item);
                        Clipboard.SetImage(img);
                        richTextBox1.Paste();
                    }
                }
            }
        }
    }
}
