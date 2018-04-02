using ProyectoFinal_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoFinal_2015_0944.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Persona { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<CompraDetalle> CD { get; set; }
        public DbSet<Compras> Compra { get; set; }
        public DbSet<Departamentos> Departamento { get; set; }
        public DbSet<FacturaDetalle> FD { get; set; }
        public DbSet<Facturas> Factura { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<TiposDePersonas> TipoDePersona { get; set; }

        public Contexto() : base("ConStr")
        {

        }

    }
}
