using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testeazadacaeprim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i, ok = 1;
            int n = 0;
            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch(Exception)
            {
                n = 0;
            }
            if(n>9999)
            {
                MessageBox.Show("Nr mai mic te rog");
            }
            if (n <= 1)
            {
                ok = 0;
            }
            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    ok = 0;
            }
            if (ok == 1)
            {
                BackColor = Color.Green;
                label2.Text = ("Nr tau e PRIM");
            }
            else
            {
                BackColor = Color.Red;
                label2.Text = ("Nr tau NU e PRIM");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
                MessageBox.Show("Esti foarte amuzant!");
                BackColor = Color.White;
            }
        }

        
    }
}
