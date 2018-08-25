using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal_2015_0944.Entidades
{
    public class Facturas
    {
        [Key]
        public int IdFactura { get; set; }

        public int IdPersona { get; set; }
        public int IdProducto { get; set; }
        public DateTime Fecha { get; set; }
        public Double Monto { get; set; }
        public String Observacion { get; set; }
        public virtual List<FacturaDetalle> Lista { get; set; }

        public Facturas(int idFactura, int idPersona, DateTime fecha, double monto, string observacion)
        {
            IdFactura = idFactura;
            IdPersona = idPersona;
            Fecha = fecha;
            Monto = monto;
            Observacion = observacion;
        }

        public Facturas()
        {
            IdFactura = 0;
            IdPersona = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Observacion = String.Empty;
            Lista = new List<FacturaDetalle>();
        }
    }
}
