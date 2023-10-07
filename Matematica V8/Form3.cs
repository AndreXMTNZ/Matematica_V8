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
    public partial class aagudos : Form
    {
        public aagudos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCatetoMenor.Text, out double catetoMenor) &&
    double.TryParse(txtCatetoMayor.Text, out double catetoMayor))
            {
                // Calcular hipotenusa
                double hipotenusa = Math.Sqrt(Math.Pow(catetoMenor, 2) + Math.Pow(catetoMayor, 2));

                // Calcular ángulo B
                double anguloB = Math.Atan(catetoMenor / catetoMayor) * (180 / Math.PI);

                // Calcular ángulo C
                double anguloC = 90 - anguloB;

                // Mostrar resultados en TextBox
                txtHipotenusa.Text = $"Hipotenusa: {hipotenusa:F2}";
                txtAnguloB.Text = $"Ángulo B: {anguloB:F2}°";
                txtAnguloC.Text = $"Ángulo C: {anguloC:F2}°";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para los catetos.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            // Limpiar los datos en TextBox
            txtCatetoMenor.Clear();
            txtCatetoMayor.Clear();
            txtHipotenusa.Clear();
            txtAnguloB.Clear();
            txtAnguloC.Clear();
        }

        private void btnrg_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
            //FIN
        }
    }

}
