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
    public partial class AdminPanel : BaseForm
    {
        private GestorDatos gestorDatos = new GestorDatos();
        private DataGridView dgvLaptops = new DataGridView();

        public AdminPanel()
        {
            InitializeComponent();
            ConfigurarInterfaz();
            CargarDatos();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarInterfaz()
        {
            // Configurar DataGridView
            dgvLaptops = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false
            };

            // Botones de acción
            Button btnAgregar = new Button
            {
                Text = "Agregar Laptop",
                Dock = DockStyle.Top,
                Height = 50,
                Width = 150,
                Padding = new Padding(10),
                Margin = new Padding(5),
            };
            btnAgregar.Click += BtnAgregar_Click;

            Button btnEditar = new Button
            {
                Text = "Editar Laptop",
                Dock = DockStyle.Top,
                Height = 50,
                Width = 150,
                Padding = new Padding(10),
                Margin = new Padding(5),
            };
            btnEditar.Click += BtnEditar_Click;

            Button btnEliminar = new Button
            {
                Text = "Eliminar Laptop",
                Dock = DockStyle.Top,
                Height = 50,
                Width = 150,
                Padding= new Padding(10),
                Margin = new Padding(5)
            };
            btnEliminar.Click += BtnEliminar_Click;

            Panel panelBotones = new Panel
            {
                Height = 180,
                Dock = DockStyle.Top
            };
            panelBotones.Controls.AddRange(new Control[] { btnAgregar, btnEditar, btnEliminar });

            this.Controls.AddRange(new Control[] { panelBotones, dgvLaptops });
        }

        private void CargarDatos()
        {
            dgvLaptops.DataSource = gestorDatos.ObtenerLaptops();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (var form = new FormLaptop())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    gestorDatos.AgregarLaptop(form.Laptop);
                    CargarDatos();
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLaptops.CurrentRow != null)
            {
                var laptop = (Laptop)dgvLaptops.CurrentRow.DataBoundItem;
                using (var form = new FormLaptop(laptop))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        gestorDatos.ActualizarLaptop(form.Laptop);
                        CargarDatos();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLaptops.CurrentRow != null)
            {
                var laptop = (Laptop)dgvLaptops.CurrentRow.DataBoundItem;
                if (MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gestorDatos.EliminarLaptop(laptop.Id);
                    CargarDatos();
                }
            }
        }
    }
}
