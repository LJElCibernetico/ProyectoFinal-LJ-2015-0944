using ProyectoFinal_2015_0944.DAL;
using ProyectoFinal_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal_2015_0944.BLL
{
    public class FacturaDetalleBLL
    {
        public static bool Guardar(Facturas factura)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                contex.Factura.Add(factura);
                foreach (FacturaDetalle detalle in factura.Lista)
                    contex.FD.Add(detalle);

                contex.SaveChanges();
                contex.Dispose();
                paso = true;
            }
            catch (Exception )
            {
                throw;
            }

            return paso;
        }

        public static bool Modificar(Facturas factura)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                contex.Entry(factura).State = System.Data.Entity.EntityState.Modified;
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                Facturas factura = contex.Factura.Find(id);
                contex.Factura.Remove(factura);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Facturas Buscar(int id)
        {
            Facturas factura = null;
            try
            {
                Contexto db = new Contexto();
                factura = db.Factura.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }

        public static List<FacturaDetalle> GetList(Expression<Func<FacturaDetalle, bool>> filter)
        {
            List<FacturaDetalle> factura = null;

            try
            {
                Contexto contex = new Contexto();
                factura = contex.FD.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }

        public static List<Facturas> GetList1(Expression<Func<Facturas, bool>> filter)
        {
            List<Facturas> factura = null;

            try
            {
                Contexto contex = new Contexto();
                factura = contex.Factura.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }
    }
}
