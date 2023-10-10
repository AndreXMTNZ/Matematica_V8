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
    public partial class mcd : Form
    {
        public mcd()
        {
            InitializeComponent();
        }

        private void mcd_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //AQUI PROGRAMA

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


            //calculitos calculitos 


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void brnregresar_Click_1(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void btnLipiar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtX1.Text = "";
            txtA.Focus();
        }
    }
}
