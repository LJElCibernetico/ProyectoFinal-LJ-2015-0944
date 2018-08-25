using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal_2015_0944.Entidades
{
    public class Personas
    {
        [Key]
        public int IdPersona { get; set; }

        public int IdTipoDePersona { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String Email { get; set; }

        public Personas(int idPersona, int idTipoDePersona, string nombre, string apellido, string telefono, string direccion, string email)
        {
            IdPersona = idPersona;
            IdTipoDePersona = idTipoDePersona;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
        }

        public Personas()
        {
            IdPersona = 0;
            IdTipoDePersona = 0;
            Nombre = String.Empty;
            Apellido = String.Empty;
            Telefono = String.Empty;
            Direccion = String.Empty;
            Email = String.Empty;
        }
    }
}
