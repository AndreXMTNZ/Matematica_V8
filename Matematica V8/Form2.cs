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
    public partial class Ecuadratica : Form
    {
        public Ecuadratica()
        {
            InitializeComponent();
        }

        private void Ecuadratica_Load(object sender, EventArgs e)
        {

        }

        private void brnregresar_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validamos la entrada
            if (txtA.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en 'a'", "Error");
                txtA.Focus();
                return;
            }
            double a;
            try
            {
                a = Convert.ToDouble(txtA.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numerico en 'a'", "Error");
                txtA.Text = "";
                txtA.Focus();
                return;
            }

            if (txtB.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en 'b'", "Error");
                txtB.Focus();
                return;
            }
            double b;
            try
            {
                b = Convert.ToDouble(txtB.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numerico en 'b'", "Error");
                txtB.Text = "";
                txtB.Focus();
                return;
            }

            if (txtC.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en 'c'", "Error");
                txtC.Focus();
                return;
            }
            double c;
            try
            {
                c = Convert.ToDouble(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numerico en 'c'", "Error");
                txtC.Text = "";
                txtC.Focus();
                return;
            }

            //Hacemos los calculos
            double x1, x2;
            EcuacionCuadratica(a, b, c, out x1, out x2);

            //Mostrar resusltados
            txtX1.Text = Math.Round(x1, 2).ToString();
            txtX2.Text = Math.Round(x2, 2).ToString();
            if (txtX1.Text == "NaN")
            {
                txtX1.Text = "Respuesta imaginaria";
            }
            if (txtX2.Text == "NaN")
            {
                txtX2.Text = "Respuesta imaginaria";
            }
        }

        private void EcuacionCuadratica(double a, double b, double c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
        private void btnLipiar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
            txtA.Focus();
        }

    }
}

