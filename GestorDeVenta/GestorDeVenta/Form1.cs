using System.Text.RegularExpressions;

namespace GestorDeVenta
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        GestorDatos gd = new GestorDatos();

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            gd.CargarUsuarios();
            string nombre = txtUsuario.Text;
            string contrasenia = txtContra.Text;
            string e_mail = txtEmail.Text;

            if (!gd.UsuarioRegistrado(nombre, contrasenia))
            {
                MessageBox.Show("Los datos son incorrectos");
            }
            else
            {
                Catalogo catalogo = new Catalogo();
                catalogo.Show();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Show();
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
    }
}
