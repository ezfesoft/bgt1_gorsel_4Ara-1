using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt1_gorsel_4Ara_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt32(textBox2.Text);
            double sayi;
            sayi = Convert.ToDouble(textBox1.Text);
            double sonuc;
            if (yas <= 12)
            {
                sonuc = sayi * 0.5;
            }
            else if (yas <= 24)
            {
                sonuc = sayi * 0.9;
            }
            else if (yas >= 65)
            {
                sonuc = sayi * 0.7;
            }
            else
            {
                sonuc = sayi;
            }
            label5.Text = Convert.ToString(sonuc);




        }
    }
}
