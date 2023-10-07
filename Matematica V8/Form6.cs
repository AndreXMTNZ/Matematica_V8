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
            textBoxJuan.Text = $"${montoJuan}";
            textBoxLuis.Text = $"${montoLuis}";
            textBoxRosa.Text = $"${montoRosa}";
            textBoxAbogadoResultado.Text = $"${montoAbogado}";
        }//finish
    }
}
