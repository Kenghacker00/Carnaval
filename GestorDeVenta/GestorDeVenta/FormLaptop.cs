using System;
using System.Windows.Forms;

namespace GestorDeVenta
{
    public partial class FormLaptop : Form
    {
        public Laptop Laptop { get; private set; }

        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtProcesador;
        private NumericUpDown numRAM;
        private TextBox txtAlmacenamiento;
        private NumericUpDown numPrecio;
        private TextBox txtImagenUrl;
        private NumericUpDown numStock;

        public FormLaptop()
        {
            InitializeComponent();
            InicializarInterfaz();
        }

        public FormLaptop(Laptop laptop) : this()
        {
            Laptop = laptop;
            CargarDatosLaptop();
        }

        private void InicializarInterfaz()
        {
            this.Text = "Detalles de Laptop";
            this.Size = new System.Drawing.Size(400, 500);

            TableLayoutPanel panel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 9
            };

            // Marca
            panel.Controls.Add(new Label { Text = "Marca:" }, 0, 0);
            txtMarca = new TextBox { Dock = DockStyle.Fill };
            panel.Controls.Add(txtMarca, 1, 0);

            // Modelo
            panel.Controls.Add(new Label { Text = "Modelo:" }, 0, 1);
            txtModelo = new TextBox { Dock = DockStyle.Fill };
            panel.Controls.Add(txtModelo, 1, 1);

            // Procesador
            panel.Controls.Add(new Label { Text = "Procesador:" }, 0, 2);
            txtProcesador = new TextBox { Dock = DockStyle.Fill };
            panel.Controls.Add(txtProcesador, 1, 2);

            // RAM
            panel.Controls.Add(new Label { Text = "RAM (GB):" }, 0, 3);
            numRAM = new NumericUpDown { Dock = DockStyle.Fill, Minimum = 1, Maximum = 128 };
            panel.Controls.Add(numRAM, 1, 3);

            // Almacenamiento
            panel.Controls.Add(new Label { Text = "Almacenamiento:" }, 0, 4);
            txtAlmacenamiento = new TextBox { Dock = DockStyle.Fill };
            panel.Controls.Add(txtAlmacenamiento, 1, 4);

            // Precio
            panel.Controls.Add(new Label { Text = "Precio:" }, 0, 5);
            numPrecio = new NumericUpDown { Dock = DockStyle.Fill, Minimum = 0, Maximum = 1000000, DecimalPlaces = 2 };
            panel.Controls.Add(numPrecio, 1, 5);

            // Imagen URL
            panel.Controls.Add(new Label { Text = "URL de Imagen:" }, 0, 6);
            txtImagenUrl = new TextBox { Dock = DockStyle.Fill };
            panel.Controls.Add(txtImagenUrl, 1, 6);

            // Stock
            panel.Controls.Add(new Label { Text = "Stock:" }, 0, 7);
            numStock = new NumericUpDown { Dock = DockStyle.Fill, Minimum = 0, Maximum = 1000 };
            panel.Controls.Add(numStock, 1, 7);

            // Botón Aceptar
            Button btnAceptar = new Button { Text = "Aceptar", Dock = DockStyle.Fill };
            btnAceptar.Click += BtnAceptar_Click;
            panel.Controls.Add(btnAceptar, 1, 8);

            this.Controls.Add(panel);
        }

        private void CargarDatosLaptop()
        {
            if (Laptop != null)
            {
                txtMarca.Text = Laptop.Marca;
                txtModelo.Text = Laptop.Modelo;
                txtProcesador.Text = Laptop.Procesador;
                numRAM.Value = Laptop.RAM;
                txtAlmacenamiento.Text = Laptop.Almacenamiento;
                numPrecio.Value = Laptop.Precio;
                txtImagenUrl.Text = Laptop.ImagenUrl;
                numStock.Value = Laptop.Stock;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Laptop = new Laptop
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Procesador = txtProcesador.Text,
                    RAM = (int)numRAM.Value,
                    Almacenamiento = txtAlmacenamiento.Text,
                    Precio = numPrecio.Value,
                    ImagenUrl = txtImagenUrl.Text,
                    Stock = (int)numStock.Value
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Implementación del método Load para evitar la NotImplementedException
        private void FormLaptop_Load(object sender, EventArgs e)
        {
            // Este método puede quedar vacío si no necesitas realizar ninguna acción específica al cargar el formulario
        }
    }
}