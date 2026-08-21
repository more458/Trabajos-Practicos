namespace Practico2
{
    public partial class LForm1 : Form
    {
        public LForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TGuardar_Click(object sender, EventArgs e)
        {
           
            if (TDni.Text == "" || TApellido.Text == "" || TNombre.Text == "")
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            DialogResult ask;
            ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           
            if (ask == DialogResult.Yes)
            {
                
                string cliente = TNombre.Text + " " + TApellido.Text;

                
                LModificar.Text = cliente;

                
                MessageBox.Show("El Cliente: " + cliente + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            {
                
                string cliente = TNombre.Text + " " + TApellido.Text;

                DialogResult ask;
                ask = MessageBox.Show(
                    "Está punto de eliminar el Cliente: " + cliente,
                    "Confirmar Eliminacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2 
                );

                
                if (ask == DialogResult.Yes)
                {
                    
                    TDni.Clear();
                    TApellido.Clear();
                    TNombre.Clear();

                   
                    LModificar.Text = "";

                   
                    MessageBox.Show(
                        "El Cliente: " + cliente + " se eliminó correctamente",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
               
            }
        }
    }
}
