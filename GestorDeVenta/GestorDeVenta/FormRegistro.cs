using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class FormRegistro : BaseForm
    {
        public FormRegistro()
        {
            InitializeComponent();
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string patron = @"^[\w-\.]+@aragonsolutions\.net$";
            Regex rgx = new Regex(patron);
            if (!rgx.IsMatch(txtEmail.Text))
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


            MessageBox.Show("Usuario registrado con éxito!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }
}