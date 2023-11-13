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
    public partial class Herencia : Form
    {
        public Herencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el valor total de la herencia desde el TextBox
            double herenciaTotal = Convert.ToDouble(textBoxHerencia.Text);


            // Calcular las herencias según las fórmulas proporcionadas
            double montoJuan = herenciaTotal / 3;
            double montoLuis = (4 * herenciaTotal) / 9;
            double montoRosa = (2 * herenciaTotal) / 9;

            // Calcular el porcentaje que el abogado cobrará
            Double j = herenciaTotal / 3;
            Double l = (4 * herenciaTotal) / 9;
            Double r = (2 * herenciaTotal) / 9;

            Double b = 0;
            Double b1 = 0;
            Double b2 = 0;
            Double b3 = 0;

            if (j < (herenciaTotal / 3))
            {
                b1 = j * 0.03;
            }
            if (j >= (herenciaTotal / 3))
            {
                b1 = j * 0.05;
            }

            if (l < (herenciaTotal / 3))
            {
                b2 = l * 0.03;
            }
            if (l >= (herenciaTotal / 3))
            {
                b2 = l * 0.05;
            }

            if (r < (herenciaTotal / 3))
            {
                b3 = r * 0.03;
            }
            if (r >= (herenciaTotal / 3))
            {
                b3 = r * 0.05;
            }

            b = b1 + b2 + b3;


            // Mostrar los resultados en los TextBoxes individuales
            textBoxJuan.Text = $"${Math.Round(montoJuan, 3)}";
            textBoxLuis.Text = $"${Math.Round(montoLuis, 3)}";
            textBoxRosa.Text = $"${Math.Round(montoRosa, 3)}";
            textBoxAbogadoResultado.Text = b.ToString("C2");

        }  //finish

        private void REGRE_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            textBoxHerencia.Clear();
            textBoxJuan.Clear();
            textBoxRosa.Clear();
            textBoxAbogadoResultado.Clear();

        }

        private void textBoxHerencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Herencia_Load(object sender, EventArgs e)
        {

        }

        private void LIMPIAR_Click_1(object sender, EventArgs e)
        {
            textBoxHerencia.Clear();
            textBoxJuan.Clear();
            textBoxRosa.Clear();
            textBoxLuis.Clear();
            textBoxAbogadoResultado.Clear();
        }

        private void REGRE_Click_1(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void textBoxAbogadoResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxHerencia.Clear();
            textBoxJuan.Clear();
            textBoxRosa.Clear();
            textBoxLuis.Clear();
            textBoxAbogadoResultado.Clear();
        }

        private void regreboton_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }
    }
}
