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
        primeList myPrimes = new primeList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Number1TextBox.Text);
            int num2 = Convert.ToInt32(Number2TextBox.Text);
            int direction, counter;
            counter = 0;
            int[] primes = new int[5];
            if (num1 < num2)
            {
                direction = 1;
            }
            else if (num1 > num2)
            {
                direction = -1;
            }
            else
            {
                if (isPrime(num1)) { OutputTextBox.Text = num1.ToString(); }
                return;
            }
            for (int i = num1; i != num2; i = i + direction)
            {
                if (counter == 5)
                {
                    myPrimes.add(primes[0], primes[1], primes[2], primes[3], primes[4]);
                    primes = new int[5];
                    counter = 0;
                }
                if (isPrime(i))
                {
                    primes[counter] = i;
                    counter++;
                }
            }
            if (primes.Length != 0)
            {
                myPrimes.add(primes[0], primes[1], primes[2], primes[3], primes[4]);
            }
            printAllPrimes(myPrimes);
        }
        private Boolean isPrime(int n)
        {
            Boolean b = true;
            for (int i = 2; i < n; i++)
            {
                if ((n % i) == 0)
                {
                    b = false;
                    break;
                }
            }
            return b;
        }
        private void printAllPrimes(primeList primeL) {
            primeSet pointer = primeL.head;
            while (true)
            {
                    OutputTextBox.Text = OutputTextBox.Text+(pointer.primes[0] + " ," + pointer.primes[1] + " ," + pointer.primes[2] + " ," +
                            pointer.primes[3] + " ," + pointer.primes[4] + "\n");
                if (pointer.next == null)
                {
                    break;
                }
                pointer = pointer.next;
            }
        }
        class primeSet
        {
            public int[] primes = new int[5];
            public primeSet next = null;
        }

        class primeList
        {

            public primeSet head = null;

            public void add(int n1, int n2, int n3, int n4, int n5)
            {
                primeSet primeS = new primeSet();
                primeS.primes[0] = n1;
                primeS.primes[1] = n2;
                primeS.primes[2] = n3;
                primeS.primes[3] = n4;
                primeS.primes[4] = n5;
                primeSet pointer = head;
                if (head == null)
                {
                    head = primeS;
                }
                else if (head.next == null)
                {
                    head.next = primeS;
                }
                else
                {
                    while (pointer.next.next != null)
                    {
                        pointer = pointer.next;
                    }
                    pointer.next.next = primeS;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            OutputTextBox.ReadOnly = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Number1TextBox.Clear();
            Number2TextBox.Clear();
            OutputTextBox.Clear();
            myPrimes = new primeList();
        }
    }
}