using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class Facturas
    {
        [Key]
        public int IdFactura { get; set; }

        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public DateTime Fecha { get; set; }
        public Double Monto { get; set; }
        public String Observacion { get; set; }
        public virtual List<FacturaDetalle> Lista { get; set; }

        public Facturas(int idFactura, int idCliente, int idProducto, DateTime fecha, double monto, string observacion, List<FacturaDetalle> lista)
        {
            IdFactura = idFactura;
            IdCliente = idCliente;
            IdProducto = idProducto;
            Fecha = fecha;
            Monto = monto;
            Observacion = observacion;
            Lista = lista;
        }

        public Facturas()
        {
            IdFactura = 0;
            IdCliente = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Observacion = String.Empty;
            Lista = new List<FacturaDetalle>();
        }
    }
}
