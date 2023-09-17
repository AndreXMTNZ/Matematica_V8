using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Matematica_V8
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnecu_Click(object sender, EventArgs e)
        {
            Ecuadratica ventana = new Ecuadratica();
            ventana.Show();
            this.Hide();
        }

        private void btnaa_Click(object sender, EventArgs e)
        {
            aagudos ventana = new aagudos();
            ventana.Show();
            this.Hide();
        }

        private void btndevs_Click(object sender, EventArgs e)
        {
            Devs ventana = new Devs();
            ventana.Show();
            this.Hide();
        }
    }
}