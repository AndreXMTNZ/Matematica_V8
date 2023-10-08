﻿using System;
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
    }
}
