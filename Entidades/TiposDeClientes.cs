using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposDeClientes
    {
        [Key]
        public int IdTipoDeCliente { get; set; }

        public String Tipo { get; set; }

        public TiposDeClientes(int idTipoDeCliente, string nombre)
        {
            IdTipoDeCliente = idTipoDeCliente;
            Tipo = nombre;
        }

        public TiposDeClientes()
        {
            IdTipoDeCliente = 0;
            Tipo = String.Empty;
        }
    }
}
