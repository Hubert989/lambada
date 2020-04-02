using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lambdaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Func<double, double, double> potega = (x, n) => Math.Pow(x, n);

        Func<int, string> napis = (n) =>
        {
            Random rand = new Random();
            char[] znaki = new char[n];
            for (int i = 0; i < n; i++)
            {
                znaki[i] = (char)rand.Next(97, 123);
            }
            String str = new String(znaki);
            return str;
        };

       
        private void zad1_Click(object sender, EventArgs e)
        {
            
                double n = double.Parse(tB1.Text);
                Func<double, double> potega = x => Math.Pow(x, n);
                rtB2.Text = potega(double.Parse(tB2.Text)).ToString();
            
        }

        private void zad2_Click(object sender, EventArgs e)
        {
            
                string wyraz1 = tB1.Text;
                string wyraz2 = tB2.Text;

                Func<string, string, string> sklejone = (x, y) => x+" " + y;
                rtB2.Text = sklejone(wyraz1, wyraz2);
            
        }

        private void zad3_Click(object sender, EventArgs e)
        {
            
                rtB2.Text = napis(int.Parse(tB1.Text));
            
        }

        private void zad4_Click(object sender, EventArgs e)
        {
           
                int liczba = int.Parse(tB1.Text);
                double[] tab = new double[10];
                for (int i = 0; i < 10; i++)
                {
                    tab[i] = potega(liczba, i);
                    rtB2.Text += i+"."+tab[i] + "\n";
                }
            
        }

        private void zad5_Click(object sender, EventArgs e)
        {

        }

        private void zad6_Click(object sender, EventArgs e)
        {
           
                string s = tB1.Text;
                String[] split;
                split = s.Split(' ');
                int[] liczby = new int[split.Length];
                for (int i = 0; i < split.Length; i++)
                {
                    liczby[i] = int.Parse(split[i]);
                }
                Array.Sort(liczby, (a, b) => b - a);
                for (int i = 0; i < liczby.Length; i++)
                {
                    rtB2.Text += " " +liczby[i];
                }

                rtB2.Text += "\n";

                Array.Sort(liczby, (a, b) => a - b);
                for (int i = 0; i < liczby.Length; i++)
                {
                    rtB2.Text +=" " +liczby[i];
                }
            
        }

        private void zad7_Click(object sender, EventArgs e)
        {
            
                string s = tB1.Text;
                String[] split;
                split = s.Split(' ');
                int[] liczby = new int[split.Length];
                for (int i = 0; i < split.Length; i++)
                {
                    liczby[i] = int.Parse(split[i]);
                }
                Array.Sort(liczby, (a, b) => a % 2 == b % 2 ? 1 : a % 2 == 0 ? -1 : 1);
                Array.Sort(liczby, (a, b) => a % 2 == b % 2 ? a - b : a % 2 == 0 ? -1 : 1);
                for (int i = 0; i < liczby.Length; i++)
                {
                    rtB2.Text +=" " + liczby[i];
                }
            
        }

        private void zad8_Click(object sender, EventArgs e)
        {
            
                string s = tB1.Text;
                String[] split;
                split = s.Split(' ');
                int[] liczby = new int[split.Length];


                Array.Sort(split, (a, b) => a.CompareTo(b));
                for (int i = 0; i < liczby.Length; i++)
                {
                    rtB2.Text += " " + split[i];
                }
            
        }

       
        public double podnoszenie(double x)
        {
            double a = double.Parse(tB1.Text);
            return potega(a, x);
        }
        private void zad9_Click(object sender, EventArgs e)
        {
            podnoszenie(double.Parse(tB2.Text));
        }
    }
}
