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

            double porcentajeAbogado = (herenciaTotal < (herenciaTotal / 3)) ? 0.03 : 0.05;
            double montoAbogado = herenciaTotal * porcentajeAbogado;

            // Mostrar los resultados en los TextBoxes individuales
            textBoxJuan.Text = $"${Math.Round(montoJuan, 3)}";
            textBoxLuis.Text = $"${Math.Round(montoLuis, 3)}";
            textBoxRosa.Text = $"${Math.Round(montoRosa, 3)}";
            textBoxAbogadoResultado.Text = $"${Math.Round(montoAbogado, 3)}";
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
    }
}
