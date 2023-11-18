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
    public partial class PlanoC : Form
    {


        public PlanoC()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt.Text, out int x) && int.TryParse(txtX.Text, out int y))
            {
                // Verifica el cuadrante
                string cuadrante = ObtenerCuadrante(x, y);

                // Muestra el resultado en un MessageBox
                MessageBox.Show($"Coordenada ({x}, {y}) está en el cuadrante {cuadrante}");

                // Dibuja el plano cartesiano
                DibujarPlanoCartesiano(x, y);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos para X e Y.");
            }
        }
        private string ObtenerCuadrante(int x, int y)
        {
            if (x > 0 && y > 0)
                return "I Cuadrante";
            else if (x < 0 && y > 0)
                return "II Cuadrante";
            else if (x < 0 && y < 0)
                return "III Cuadrante";
            else if (x > 0 && y < 0)
                return "IV Cuadrante";
            else
                return "En el origen";
        }

        private void DibujarPlanoCartesiano(int x, int y)
        {
            // Dibuja el plano cartesiano en el PictureBox
            using (Graphics g = pictureBoxPlano.CreateGraphics())
            {
                // Borra el contenido anterior
                g.Clear(Color.White);

                // Dibuja los ejes
                g.DrawLine(Pens.Black, pictureBoxPlano.Width / 2, 0, pictureBoxPlano.Width / 2, pictureBoxPlano.Height);
                g.DrawLine(Pens.Black, 0, pictureBoxPlano.Height / 2, pictureBoxPlano.Width, pictureBoxPlano.Height / 2);

                // Dibuja el punto ingresado
                int puntoX = pictureBoxPlano.Width / 2 + x * 10; // Escala de 10 unidades por píxel
                int puntoY = pictureBoxPlano.Height / 2 - y * 10; // Invertir el eje Y
                g.FillEllipse(Brushes.Red, puntoX - 5, puntoY - 5, 10, 10);
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            txtX.Text = "";
            pictureBoxPlano.Text = "";
            LimpiarGrafica();
        }

        private void LimpiarGrafica()
        {
            // Limpiar el PictureBox
            using (Graphics g = pictureBoxPlano.CreateGraphics())
            {
                g.Clear(Color.White);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void pictureBoxPlano_Click(object sender, EventArgs e)
        {

        }
    }
}

