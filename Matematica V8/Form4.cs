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
    public partial class rkreamer : Form
    {
        public rkreamer()
        {
            InitializeComponent();
        }

        private void botoncalc_Click(object sender, EventArgs e)
        {
            // Obtener coeficientes de las ecuaciones
            double a11 = Convert.ToDouble(textA.Text);
            double a12 = Convert.ToDouble(textB.Text);
            double b1 = Convert.ToDouble(textR.Text);
            double a21 = Convert.ToDouble(textC.Text);
            double a22 = Convert.ToDouble(textD.Text);
            double b2 = Convert.ToDouble(textS.Text);

            // Calcular determinante del sistema original
            double detSistema = a11 * a22 - a12 * a21;

            if (detSistema != 0)
            {
                // Calcular determinantes para x e y
                double detX = b1 * a22 - a12 * b2;
                double detY = a11 * b2 - b1 * a21;

                // Calcular soluciones
                double x = detX / detSistema;
                double y = detY / detSistema;

                RESX.Text = $"{Math.Round(x, 3)}";
                RESY.Text = $"{Math.Round(y, 3)}";
            }
            else
            {
                // El sistema no tiene solución única
                RESX.Text = "No hay solución";
                RESY.Text = "No hay solución";
            }


        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            textA.Clear();
            textB.Clear();
            textR.Clear();
            textC.Clear();
            textD.Clear();
            textS.Clear();
            RESX.Clear();
            RESY.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
