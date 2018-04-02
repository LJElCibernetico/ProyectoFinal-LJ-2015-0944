using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal_2015_0944.Entidades
{
    public class CompraDetalle
    {
        [Key]
        public int IdCompraDetalle { get; set; }

        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public Double Precio { get; set; }

        public CompraDetalle(int idCompraDetalle, int idCompra, int idProducto, int cantidad, double precio)
        {
            IdCompraDetalle = idCompraDetalle;
            IdCompra = idCompra;
            IdProducto = idProducto;
            Cantidad = cantidad;
            Precio = precio;
        }

        public CompraDetalle()
        {
            IdCompraDetalle = 0;
            IdCompra = 0;
            IdProducto = 0;
            Cantidad = 0;
            Precio = 0;
        }
    }
}
