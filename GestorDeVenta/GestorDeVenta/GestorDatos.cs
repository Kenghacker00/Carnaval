﻿using OfficeOpenXml;
using System;
using System.IO;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeVenta
{
    public class GestorDatos
    {
        private const string Usuarios = "users.xlsx";
        private const string Registros = "registros.xslx";
        private const string ArchivoLaptops = "laptops.xlsx";
        private const string ArchivoVentas = "ventas.xlsx";

        public void CargarUsuarios()
        {
            if (!File.Exists(Usuarios))
            {
                var file = new FileInfo(Usuarios); 

                using (var package = new ExcelPackage(file))
                {
                    var hojatrabajo = package.Workbook.Worksheets.Add("Usuarios");
                    hojatrabajo.Cells[1, 1].Value = "Nombre";
                    hojatrabajo.Cells[1, 2].Value = "Edad";
                    hojatrabajo.Cells[1, 3].Value = "Email";
                    hojatrabajo.Cells[1, 4].Value = "Contraseña";
                    package.Save();
                }
            }
        }

        public void RegistrarUsuarios(Usuario us)
        {
            if (File.Exists(Usuarios))
            {
                var file = new FileInfo(Usuarios);

                using (var package = new ExcelPackage(file))
                {
                    var hojatrabajo = package.Workbook.Worksheets.First();
                    int cantfilas = hojatrabajo.Dimension.Rows;
                    for (int fila = 2; fila <= cantfilas; fila++)
                    {
                        if (us.Nombre == hojatrabajo.Cells[fila, 1].Text && us.Contraseña == hojatrabajo.Cells[fila, 4].Text || us.Email == hojatrabajo.Cells[fila, 3].Text && us.Edad == int.Parse(hojatrabajo.Cells[fila, 2].Text))
                        {
                            MessageBox.Show("Este usuario ya existe");
                            return;
                        }
                        if (us.Email == hojatrabajo.Cells[fila, 4].Text)
                        {
                            MessageBox.Show("Este correo ya esta registrado");
                            return;
                        }
                    }
                    hojatrabajo.Cells[cantfilas + 1, 1].Value = us.Nombre;
                    hojatrabajo.Cells[cantfilas + 1, 2].Value = us.Edad;
                    hojatrabajo.Cells[cantfilas+1, 3].Value = us.Email;
                    hojatrabajo.Cells[cantfilas+1, 4].Value = us.Contraseña;
                    package.Save();
                    MessageBox.Show("Usuario registrado con éxito!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return;
            }
        }
        public void CargarRegistros() 
        {
            // registros.xslx
        }

        public bool UsuarioRegistrado(string nombre, string contraseña)
        {
            bool UsuarioRegistrado = false;
            if (File.Exists(Usuarios))
            {
                var file = new FileInfo(Usuarios);

                using (var package = new ExcelPackage(file))
                {
                    var hojatrabajo = package.Workbook.Worksheets.First();

                    for (int fila = 2; fila <= hojatrabajo.Dimension.Rows; fila++)
                    {
                        var Nombre = hojatrabajo.Cells[fila, 1].Text;
                        var Contraseña = hojatrabajo.Cells[fila, 3].Text;

                        if (Nombre == nombre && Contraseña == contraseña)
                        {
                            UsuarioRegistrado = true;
                        }
                        else
                        {
                            UsuarioRegistrado = true;
                        }
                    }
                }
            }
            return UsuarioRegistrado;
        }

        public bool EsAdmin(string email, string password)
        {
            return email == "juanaragoncruz@aragonsolutions.net" && password == "juan35";

        }

        public List<Laptop> ObtenerLaptops()
        {
            List<Laptop> laptops = new List<Laptop>();
            if (File.Exists(ArchivoLaptops))
            {
                var file = new FileInfo(ArchivoLaptops);
                using (var package = new ExcelPackage(file))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    int rows = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rows; row++)
                    {
                        Laptop laptop = new Laptop
                        {
                            Id = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                            Marca = worksheet.Cells[row, 2].Value.ToString(),
                            Modelo = worksheet.Cells[row, 3].Value.ToString(),
                            Procesador = worksheet.Cells[row, 4].Value.ToString(),
                            RAM = int.Parse(worksheet.Cells[row, 5].Value.ToString()),
                            Almacenamiento = worksheet.Cells[row, 6].Value.ToString(),
                            Precio = decimal.Parse(worksheet.Cells[row, 7].Value.ToString()),
                            ImagenUrl = worksheet.Cells[row, 8].Value.ToString(),
                            Stock = int.Parse(worksheet.Cells[row, 9].Value.ToString())
                        };
                        laptops.Add(laptop);
                    }
                }
            }
            return laptops;
        }

        public void ActualizarLaptop(Laptop laptop)
        {

        }

        public void EliminarLaptop(int id)
        {

        }

        public void RegistrarVenta(Laptop laptop)
        {

        }

        public void AgregarLaptop(Laptop laptop)
        {

        }

    }
}
