using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
            sayı = Convert.ToInt32(textBox1.Text);

            if (sayı<0)
            {
                MessageBox.Show("0'dan büyük sayır giriniz");
            }
            
            else if (sayı<25)
            {
                MessageBox.Show("notunuz 0");
            }
            else if (sayı < 45)
            {
                MessageBox.Show("notunuz 1");
            }
            else if (sayı < 55)
            {
                MessageBox.Show("notunuz 2");
            }
            else if (sayı < 70)
            {
                MessageBox.Show("notunuz 3");
            }
            else if (sayı < 85)
            {
                MessageBox.Show("notunuz 4");
            }
            else if (sayı <=100)
            {
                MessageBox.Show("notunuz 5");
            }
        }
    }
}
