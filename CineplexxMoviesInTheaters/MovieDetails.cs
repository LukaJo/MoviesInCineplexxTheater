using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineplexxMoviesInTheaters
{
    public partial class MovieDetails : Form
    {
        public MovieDetails()
        {
            InitializeComponent();
        }

        public MovieDetails(List<List<string>> lista)
        {
            InitializeComponent();
            PopuniPolja(lista);
        }

        private void PopuniPolja(List<List<string>> lista)
        {
            try
            {
                label1.Text = lista[0][0].ToString();
                textBox1.Text = lista[0][1].ToString();
                label2.Text = lista[1][0].ToString();
                textBox2.Text = lista[1][1].ToString();
                label3.Text = lista[2][0].ToString();
                textBox3.Text = lista[2][1].ToString();
                label4.Text = lista[3][0].ToString();
                textBox4.Text = lista[3][1].ToString();
                label5.Text = lista[4][0].ToString();
                textBox5.Text = lista[4][1].ToString();
                label6.Text = lista[5][0].ToString();
                textBox6.Text = lista[5][1].ToString();
                label7.Text = lista[6][0].ToString();
                textBox7.Text = lista[6][1].ToString();
                label8.Text = lista[7][0].ToString();
                textBox8.Text = lista[7][1].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Nema svih podataka");
                return;
            }

        }
    }
}
