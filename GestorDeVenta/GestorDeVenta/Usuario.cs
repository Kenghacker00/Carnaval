using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestorDeVenta
{
    public class Usuario
    {
        private string nombre;
        public string Email { get; set; }
        private string contraseña;
        private int edad;

        public Usuario(string nombre, string email, string contraseña, int edad)
        {
            Nombre = nombre;
            Email = email;
            Contraseña = contraseña;
            Edad = edad;
        }

        public Usuario()
        {
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                if (value.Length < 2 || value.Length > 50)
                    throw new ArgumentException("El nombre debe tener entre 2 y 50 caracteres.");
                nombre = value;
            }
        }

        public static bool ValidarEmail(string email)
        {
            string patron = @"^[\w-\.]+@aragonsolutions\.net$";
            return Regex.IsMatch(email, patron);
        }

        public string Contraseña
        {
            get { return contraseña; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    throw new ArgumentException("La contraseña debe tener al menos 6 caracteres.");
                if (!Regex.IsMatch(value, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$"))
                    throw new ArgumentException("La contraseña debe contener al menos una letra minúscula, una mayúscula y un número.");
                contraseña = value;
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 18 || value > 120)
                    throw new ArgumentException("La edad debe estar entre 18 y 120 años.");
                edad = value;
            }
        }
    }
}
