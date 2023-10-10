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

        private void btnrk_Click(object sender, EventArgs e)
        {
            rkreamer ventana = new rkreamer();
            ventana.Show();
            this.Hide();
        }

        private void btnhr_Click(object sender, EventArgs e)
        {
            Herencia ventana = new Herencia();
            ventana.Show();
            this.Hide();
        }

        private void btncb_Click(object sender, EventArgs e)
        {
            Cajero ventana = new Cajero();
            ventana.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btndracucqueo_Click(object sender, EventArgs e)
        {
            mcd ventana = new mcd();
            ventana.Show();
            this.Hide();
        }
    }
}