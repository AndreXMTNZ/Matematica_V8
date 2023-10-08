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
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si la entrada es un número válido
            if (int.TryParse(txtMonto.Text, out int monto))
            {
                // Llama a la función para calcular los billetes
                CalcularBilletes(monto);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido en dólares.");
            }
        }

        private void CalcularBilletes(int monto)
        {
            // Array que almacena las denominaciones de los billetes
            int[] denominaciones = { 100, 20, 10, 5, 1 };

            // Array que almacena la cantidad de billetes para cada denominación
            int[] cantidadBilletes = new int[denominaciones.Length];

            // Itera sobre cada denominación y calcula la cantidad de billetes
            for (int i = 0; i < denominaciones.Length; i++)
            {
                cantidadBilletes[i] = monto / denominaciones[i];
                monto %= denominaciones[i];
            }

            // Muestra los resultados en un MessageBox
            string resultado = "Billetes entregados:\n";
            for (int i = 0; i < denominaciones.Length; i++)
            {
                resultado += $"{denominaciones[i]}$: {cantidadBilletes[i]}\n";
            }

            MessageBox.Show(resultado, "Resultado del retiro");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar el TextBox y cerrar la ventana
            txtMonto.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            // Manejar el evento de los botones numéricos
            Button btn = sender as Button;

            if (btn != null)
            {
                // Agregar el número al TextBox
                txtMonto.Text += btn.Text;
            }
        }

        private void Cajero_Load(object sender, EventArgs e)
        {

        }
    }
}
