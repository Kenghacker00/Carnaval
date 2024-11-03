using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class FormRegistro : BaseForm
    {
        private GestorDatos gestorDatos = new GestorDatos();

        public FormRegistro()
        {
            InitializeComponent();
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!txtEmail.Text.EndsWith("@aragonsolutions.net"))
            {
                MessageBox.Show("El correo debe terminar en '@aragonsolutions.net'");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContra.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarContra.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtContra.Text != txtConfirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Usuario nuevoUsuario = new Usuario
                {
                    Nombre = txtUsuario.Text,
                    Email = txtEmail.Text,
                    Contraseña = txtContra.Text,
                    Edad = int.Parse(txtEdad.Text)

                };
                gestorDatos.RegistrarUsuarios(nuevoUsuario);
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);              
            }
        }
    }
}