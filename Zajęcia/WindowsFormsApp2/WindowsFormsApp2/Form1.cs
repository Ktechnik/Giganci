using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void btn_sprawdz_Click(object sender, EventArgs e)
        {
            string imie = txt_imie.Text;
            string nazwisko = txt_nazwisko.Text;
            string tekst = imie + nazwisko;
            if ((imie.Equals("")!=true) && (nazwisko.Equals("")!=true))
            {
                if (tekst.Length > 30)
                {
                    MessageBox.Show("Dobra długość nazwiska i imenia");
                }
                else
                {
                    MessageBox.Show("Za krótkie to twoje imie i na zwisko. PS. idźiiii do urzędu i znień ;)");
                }
            }
            else
            {
                MessageBox.Show("Weź człowieku naucz się wypełniać pola !!!!!!!");
            }
        }
    }
}
