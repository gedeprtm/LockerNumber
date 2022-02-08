using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nilai = 0;
            nilai = int.Parse(textBox1.Text);
            if (nilai < 6)
            {
                listBox1.Text = "Lt. 1";
            }
            else if (nilai < 12)
            {
                listBox1.Text = "Lt. 2";
            }
            else if (nilai < 19)
            {
                listBox1.Text = "Lt. 3";
            }
            else if (nilai < 24)
            {
                listBox1.Text = "Lt. 4";
            }
            else if (nilai < 30)
            {
                listBox1.Text = "Lt. 5";
            }
            else if (nilai < 37)
            {
                listBox1.Text = "Lt. 6";
            }
            else if (nilai < 42)
            {
                listBox1.Text = "Lt. 7";
            }
            else if (nilai < 48)
            {
                listBox1.Text = "Lt. 8";
            }
            else if (nilai < 55)
            {
                listBox1.Text = "Lt. 9";
            }
            else
            {
                listBox1.Text = "Nomor Loker Tidak Tersedia!";
            }
            listBox1.Items.Add(nilai + " : " + listBox1.Text);
        }
    }
}
