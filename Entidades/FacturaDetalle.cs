using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    [Serializable]
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
