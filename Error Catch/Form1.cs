using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try kısmı kodlarda hata yoksa çalışacaktır.
            try
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);
                sonuc = s1 / s2;
                label1.Text = sonuc.ToString();
                label1.Visible = true;
                MessageBox.Show("Try kısmı çalıştı");
            }
            //kodlarda hata varsa catch bloğundaki kısımlar çalışacaktır.
            catch (Exception hata)
            {
                MessageBox.Show("Hata olduğu için catch kısmı çalıştı");
            }
            //finally her durumda çalışır.
            finally
            {
                MessageBox.Show("Finally kısmı çalıştı");
            }


        }
    }
}
