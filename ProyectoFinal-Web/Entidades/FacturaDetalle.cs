using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal_2015_0944.Entidades
{
    public class FacturaDetalle
    {
        [Key]
        public int IdFacturaDetalle { get; set; }

        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public Double Precio { get; set; }
        public Double Importe { get; set; }

        public FacturaDetalle(int idFacturaDetalle, int idFactura, int idProducto, int cantidad, double precio, double importe)
        {
            IdFacturaDetalle = idFacturaDetalle;
            IdFactura = idFactura;
            IdProducto = idProducto;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }

        public FacturaDetalle()
        {
            IdFacturaDetalle = 0;
            IdFactura = 0;
            IdProducto = 0;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
        }
    }
}
