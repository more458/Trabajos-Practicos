namespace Practico1
{
    public partial class formulario1 : Form
    {
        public formulario1()
        {
            InitializeComponent();
        }

        private void formulario1_Load(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtApellido.Text + " " + txtNombre.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtApellido.Clear();
            txtNombre.Clear();

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
