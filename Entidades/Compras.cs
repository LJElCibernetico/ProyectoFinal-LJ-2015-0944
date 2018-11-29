using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Compras
    {
        [Key]
        public int IdCompra { get; set; }

        public int IdPersona { get; set; }
        public int IdFactura { get; set; }
        public Double Monto { get; set; }
        public virtual List<CompraDetalle> Lista { get; set; }


        public Compras(int idCompra, int idPersona, int idFactura, double monto)
        {
            IdCompra = idCompra;
            IdPersona = idPersona;
            IdFactura = idFactura;
            Monto = monto;
        }

        public Compras()
        {
            IdCompra = 0;
            IdPersona = 0;
            IdFactura = 0;
            Monto = 0;
            Lista = new List<CompraDetalle>();
        }
    }
}
