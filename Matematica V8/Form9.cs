using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematica_V8
{
    public partial class Ordenamiento : Form
    {
        public Ordenamiento()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Validamos la entrada
            if (txtb1.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en 'a'", "Error");
                txtb1.Focus();
                return;
            }
            double a;
            try
            {
                a = Convert.ToDouble(txtb1.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numerico en 'a'", "Error");
                txtb1.Text = "";
                txtb1.Focus();
                return;
            }

            if (txtb2.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en 'b'", "Error");
                txtb2.Focus();
                return;
            }
            double b;
            try
            {
                b = Convert.ToDouble(txtb2.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numerico en 'b'", "Error");
                txtb2.Text = "";
                txtb2.Focus();
                return;
            }

            if (txtb3.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en 'c'", "Error");
                txtb3.Focus();
                return;
            }
            double c;
            try
            {
                c = Convert.ToDouble(txtb3.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numerico en 'c'", "Error");
                txtb3.Text = "";
                txtb3.Focus();
                return;
            }

            //Hacemos los calculos.
            //Numero mayor
            if (a > b && a > c)
            {
                // Mostrar resultados
                txt6.Text = a.ToString();
            }
            if (b > a && b > c)
            {
                // Mostrar resultados
                txt6.Text = b.ToString();
            }
            if (c > a && c > b)
            {
                // Mostrar resultados
                txt6.Text = c.ToString();
            }

            //Numero medio
            //Comprobacion A
            if (a > b && a < c)
            {
                // Mostrar resultados
                txt5.Text = a.ToString();
            }
            if (a > c && a < b)
            {
                // Mostrar resultados
                txt5.Text = a.ToString();
            }

            //Comprobacion B
            if (b > a && b < c)
            {
                // Mostrar resultados
                txt5.Text = b.ToString();
            }
            if (b > c && b < a)
            {
                // Mostrar resultados
                txt5.Text = b.ToString();
            }

            //Comprobacion C
            if (c > a && c < b)
            {
                // Mostrar resultados
                txt5.Text = c.ToString();
            }
            if (c > b && c < a)
            {
                // Mostrar resultados
                txt5.Text = c.ToString();
            }


            //Numero menor
            if (a < b && a < c)
            {
                // Mostrar resultados
                txt4.Text = a.ToString();
            }
            if (b < a && b < c)
            {
                // Mostrar resultados
                txt4.Text = b.ToString();
            }
            if (c < a && c < b)
            {
                // Mostrar resultados
                txt4.Text = c.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtb1.Text = "";
            txtb2.Text = "";
            txtb3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txtb1.Focus();
        }
    }
}
