using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Departamentos
    {
        [Key]
        public int IdDepartamento { get; set; }

        public String Departamento { get; set; }

        public Departamentos(int idDepartamento, string departamento)
        {
            IdDepartamento = idDepartamento;
            Departamento = departamento;
        }

        public Departamentos()
        {
            IdDepartamento = 0;
            Departamento = String.Empty;
        }
    }
}
