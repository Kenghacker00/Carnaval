using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeVenta
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Procesador { get; set; }
        public int RAM { get; set; }
        public string Almacenamiento { get; set; }
        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }
        public int Stock { get; set; }
    }
}
