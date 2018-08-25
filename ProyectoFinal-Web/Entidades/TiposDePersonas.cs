using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal_2015_0944.Entidades
{
    public class TiposDePersonas
    {
        [Key]
        public int IdTipoDePersona { get; set; }

        public String Tipo { get; set; }

        public TiposDePersonas(int idTipoDePersona, string nombre)
        {
            IdTipoDePersona = idTipoDePersona;
            Tipo = nombre;
        }

        public TiposDePersonas()
        {
            IdTipoDePersona = 0;
            Tipo = String.Empty;
        }
    }
}
