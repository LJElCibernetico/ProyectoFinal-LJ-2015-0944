﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        public int IdTipoDeCliente { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String Email { get; set; }

        public Clientes(int idCliente, int idTipoDeCliente, string nombre, string apellido, string telefono, string direccion, string email)
        {
            IdCliente = idCliente;
            IdTipoDeCliente = idTipoDeCliente;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
        }

        public Clientes()
        {
            IdCliente = 0;
            IdTipoDeCliente = 0;
            Nombre = String.Empty;
            Apellido = String.Empty;
            Telefono = String.Empty;
            Direccion = String.Empty;
            Email = String.Empty;
        }
    }
}
