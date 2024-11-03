using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class FormLaptop : Form
    {
        public Laptop Laptop { get; set; }
        public FormLaptop()
        {
            InitializeComponent();
            InicializarInterfaz();
        }

        private void FormLaptop_Load(object sender, EventArgs e)
        {

        }

        public FormLaptop(Laptop laptop)
        {
            InitializeComponent();
            InicializarInterfaz();
            CargarDatos(laptop);
        }

        private void InicializarInterfaz()
        {
            // Configurar controles
            TextBox txtMarca = new TextBox { Name = "txtMarca", PlaceholderText = "Marca" };
            TextBox txtModelo = new TextBox { Name = "txtModelo", PlaceholderText = "Modelo" };
            NumericUpDown numPrecio = new NumericUpDown { Name = "numPrecio", Minimum = 0, Maximum = 10000, DecimalPlaces = 2 };
            NumericUpDown numRAM = new NumericUpDown { Name = "numRAM", Minimum = 1, Maximum = 64 };

            Button btnAceptar = new Button { Text = "Aceptar" };
            btnAceptar.Click += BtnAceptar_Click;

            // Agregar controles al formulario
            FlowLayoutPanel panel = new FlowLayoutPanel { Dock = DockStyle.Fill };
            panel.Controls.Add(new Label { Text = "Marca:" });
            panel.Controls.Add(txtMarca);
            panel.Controls.Add(new Label { Text = "Modelo:" });
            panel.Controls.Add(txtModelo);
            panel.Controls.Add(new Label { Text = "Precio:" });
            panel.Controls.Add(numPrecio);
            panel.Controls.Add(new Label { Text = "RAM (GB):" });
            panel.Controls.Add(numRAM);
            panel.Controls.Add(btnAceptar);

            this.Controls.Add(panel);
        }

        private void CargarDatos(Laptop laptop)
        {
            // Cargar datos de laptop en controles
            TextBox txtMarca = (TextBox)this.Controls.Find("txtMarca", true)[0];
            TextBox txtModelo = (TextBox)this.Controls.Find("txtModelo", true)[0];
            NumericUpDown numPrecio = (NumericUpDown)this.Controls.Find("numPrecio", true)[0];
            NumericUpDown numRAM = (NumericUpDown)this.Controls.Find("numRAM", true)[0];

            // Asignar valores a los controles
            txtMarca.Text = laptop.Marca;
            txtModelo.Text = laptop.Modelo;
            numPrecio.Value = (decimal)laptop.Precio;
            numRAM.Value = laptop.RAM;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            TextBox txtMarca = (TextBox)this.Controls.Find("txtMarca", true)[0];
            TextBox txtModelo = (TextBox)this.Controls.Find("txtModelo", true)[0];
            NumericUpDown numPrecio = (NumericUpDown)this.Controls.Find("numPrecio", true)[0];
            NumericUpDown numRAM = (NumericUpDown)this.Controls.Find("numRAM", true)[0];

            // Validar datos y crear o actualizar el objeto Laptop
            Laptop = new Laptop
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Precio = (decimal)(double)numPrecio.Value,
                RAM = (int)numRAM.Value
            };
            DialogResult = DialogResult.OK;
        }
    }
}
