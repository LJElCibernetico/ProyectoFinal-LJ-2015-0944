using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Compras> Compra { get; set; }
        public DbSet<Departamentos> Departamento { get; set; }
        public DbSet<Facturas> Factura { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<TiposDeClientes> TipoDeCliente { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }

        public Contexto(): base("ConStr")
        {

        }
    }
}
