using OfficeOpenXml;
using System;
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
        private const string Admins = "adminis.xlsx";
        private const string Registros = "registros.xslx";

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
                    hojatrabajo.Cells[1, 3].Value = "Contraseña";
                }
                return;
            }
        }

        public void RegistrarUsuarios(string nombre, string contraseña)
        {
            if (File.Exists(Usuarios))
            {

            }
        }
        public void CargarRegistros() 
        {
            // registros.xslx
        }

        public bool UsuarioRegistrado(string nombre, string contraseña)
        {
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
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            else {
                return false;
            }
        }
    }
}
