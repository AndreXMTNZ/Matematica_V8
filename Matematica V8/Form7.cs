using Microsoft.VisualBasic;
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
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }

        private void Promedio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Validamos la entrada
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en 'Venta 1 '", "Error");
                textBox1.Focus();
                return;
            }
            double a;
            try
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numerico en 'Venta 1'", "Error");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }


            if (textBox2.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en 'Venta 2'", "Error");
                textBox2.Focus();
                return;
            }
            double b;
            try
            {
                b = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numerico en 'Venta 2'", "Error");
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }


            if (textBox3.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en 'Venta 3 '", "Error");
                textBox3.Focus();
                return;
            }
            double c;
            try
            {
                c = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numerico en 'Venta 3'", "Error");
                textBox3.Text = "";
                textBox3.Focus();
                return;
            }

            //Calculos
            double promedio, conversion;
            promedio = (a + b + c) / 3;

            conversion = Math.Round(promedio);

            if (promedio >= 500)
            {
                textBox4.Text = ("$") + conversion.ToString();
                textBox5.Text = ("Se ha ganado un regalito");
            }
            if (promedio < 499)
            {
                textBox4.Text = ("$") + conversion.ToString();
                textBox5.Text = ("Lo esperamos pronto");
            }

            //textBox4.Text = x1.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }
    }
}
