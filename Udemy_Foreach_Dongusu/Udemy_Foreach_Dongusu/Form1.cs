using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy_Foreach_Dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali","Ahmet","Pınar","Berra","Tuna" };
            foreach (string k in kisiler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sinavlar = {70,65,89,43,67 };
            foreach (int x in sinavlar)
            {
                listBox2.Items.Add(x);
                toplam = toplam + x;
            }
            label1.Text = toplam.ToString();

            int ort = toplam / sinavlar.Length;
            label2.Text = ort.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[]sayilar1 = { 12, 4, 32, 35, 68, 39, 53, 86, 34, 24 };
            foreach (int x in sayilar1)
            {        
                if (x % 4 == 0)
                {
                    listBox3.Items.Add(x);
                }

                toplam += x;
                label3.Text = toplam.ToString();

            }
        }
    }
}
