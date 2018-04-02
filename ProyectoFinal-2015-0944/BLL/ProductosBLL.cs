using ProyectoFinal_2015_0944.DAL;
using ProyectoFinal_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal_2015_0944.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos producto)
        {
            bool paso = false;
            try
            {
                Contexto Contex = new Contexto();
                Contex.Producto.Add(producto);
                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Productos producto)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Entry(producto).State = EntityState.Modified;
                if (contex.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                var p = contex.Producto.Find(Id);

                contex.Producto.Remove(p);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Productos Buscar(int Id)
        {
            Productos producto = new Productos();

            try
            {
                Contexto contex = new Contexto();
                producto = contex.Producto.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return producto;
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> criterioBusqueda)
        {
            List<Productos> Producto = new List<Productos>();
            try
            {
                Contexto contex = new Contexto();
                Producto = contex.Producto.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return Producto;
        }
    }
}
