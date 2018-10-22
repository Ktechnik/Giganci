using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Oblicz_Click(object sender, EventArgs e)
        {
            int matematka = int.Parse(txt_matma.Text);
            int polski = int.Parse(txt_polski.Text);
            int informatyka = int.Parse(txt_ifnorrmatyka.Text);
            const float prug = 4.75f;


            int suma = matematka + polski + informatyka;
            float wynik = (float)suma / 3;

            bool pasek = wynik >= prug;
           // MessageBox.Show("Czy dostaniesz pasek?" + pasek.ToString());


            if (pasek == true)
            {
                MessageBox.Show("Niestety dostaniesz pasek ;-(");
            }
            else
            {
                MessageBox.Show("Jest, nie będziesz miał paska na świadectwie HAHAHA ;-)");
            }
        }
    }
}
