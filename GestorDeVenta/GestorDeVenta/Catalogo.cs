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
    public partial class Catalogo : Form
    {
        private FlowLayoutPanel flowLayoutPanel1;
        private GestorDatos gestorDatos = new GestorDatos();
        public Catalogo()
        {
            InitializeComponent();
            inicializarInterfaz();
            CargarLaptops();
        }

        private void inicializarInterfaz()
        {
            flowLayoutPanel1 = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(flowLayoutPanel1);
        }

        private void CargarLaptops()
        {
            var laptops = gestorDatos.ObtenerLaptops();
            foreach (var lap in laptops)
            {
                var panel = CrearPanelLaptop(lap);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private Panel CrearPanelLaptop(Laptop laptop)
        {
            Panel panel = new Panel
            {
                Width = 300,
                Height = 400,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Añadir controles para mostrar información de la laptop
            PictureBox pictureBox = new PictureBox
            {
                Width = 200,
                Height = 200,
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = laptop.ImagenUrl
            };

            Label lblInfo = new Label
            {
                Text = $"{laptop.Marca} {laptop.Modelo}\n" +
                       $"Procesador: {laptop.Procesador}\n" +
                       $"RAM: {laptop.RAM}GB\n" +
                       $"Almacenamiento: {laptop.Almacenamiento}\n" +
                       $"Precio: ${laptop.Precio}",
                AutoSize = true,
                Location = new Point(10, 220)
            };

            Button btnComprar = new Button
            {
                Text = "Comprar",
                Location = new Point(10, 350)
            };
            btnComprar.Click += (s, e) => RealizarCompra(laptop);

            panel.Controls.AddRange(new Control[] { pictureBox, lblInfo, btnComprar });
            return panel;
        }

        private void RealizarCompra(Laptop laptop)
        {
            if (laptop.Stock > 0)
            {
                DialogResult result = MessageBox.Show(
                    $"¿Desea comprar {laptop.Marca} {laptop.Modelo} por ${laptop.Precio}?",
                    "Confirmar Compra",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Implementar lógica de compra
                    gestorDatos.RegistrarVenta(laptop);
                    MessageBox.Show("¡Compra realizada con éxito!");
                }
            }
            else
            {
                MessageBox.Show("Lo sentimos, este producto está agotado.");
            }
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {

        }
    }
}
