using System.Text.RegularExpressions;

namespace GestorDeVenta
{
    public partial class Form1 : BaseForm
    {
        GestorDatos gestorDatos = new GestorDatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            gestorDatos.CargarUsuarios();
            string contrasenia = txtContra.Text;
            string e_mail = txtEmail.Text;

            if (gestorDatos.EsAdmin(e_mail, contrasenia))
            {
                VerificarClaveAdmin();
            }

            else if (gestorDatos.UsuarioRegistrado(e_mail, contrasenia))
            {
                MessageBox.Show("Inicio de sesión exitoso!");
                Catalogo catalogo = new Catalogo();
                catalogo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email o contraseña no validos");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Show();
            this.Hide();
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

        private void VerificarClaveAdmin()
        {
            int intentos = 0;
            while (intentos < 3)
            {
                string clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la clave secreta de administrador:", "Verificación de Administrador", "");
                if (clave == "proyectfinal")
                {
                    MessageBox.Show("Inicio de sesión de administrador exitoso!");
                    return;
                }
                intentos++;
                if (intentos < 3)
                {
                    MessageBox.Show($"Clave incorrecta. Intentos restantes: {3 - intentos}");
                }
            }
            MessageBox.Show("Número máximo de intentos alcanzado. Acceso denegado.");
        }
    }
}
