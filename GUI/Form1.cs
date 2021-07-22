using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, sayac = 0;
            num1 = Int32.Parse(Number1TextBox.Text);
            num2 = Int32.Parse(Number1TextBox.Text);
            for (int i = num1; i < num2; i++)
            {
                sayac = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sayac = 1;
                            break;
                        }
                    }
                    if (sayac == 0)
                    {
                    }
                }
            }
            Console.ReadKey();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number1TextBox.Clear();
            Number2TextBox.Clear();
            richTextBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
    }
}

