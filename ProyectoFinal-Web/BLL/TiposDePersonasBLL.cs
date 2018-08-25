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
    public class TiposDePersonasBLL
    {
        public static EntityState EntryState { get; private set; }
        public static bool Guardar(TiposDePersonas TipoDePersona)
        {
            bool paso = false;
            try
            {
                Contexto Contex = new Contexto();
                Contex.TipoDePersona.Add(TipoDePersona);
                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(TiposDePersonas TipoDePersona)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Entry(TipoDePersona).State = EntityState.Modified;
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

                var tdp = contex.TipoDePersona.Find(Id);

                contex.TipoDePersona.Remove(tdp);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static TiposDePersonas Buscar(int Id)
        {
            TiposDePersonas TipoDePersona = new TiposDePersonas();

            try
            {
                Contexto contex = new Contexto();
                TipoDePersona = contex.TipoDePersona.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return TipoDePersona;
        }

        /*public static List<TiposDePersonas> GetList(Expression<Func<TiposDePersonas, bool>> criterioBusqueda)
        {
            List<TiposDePersonas> TipoDePersona = new List<TiposDePersonas>();
            try
            {
                Contexto contex = new Contexto();
                TipoDePersona = contex.TipoDePersona.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return TipoDePersona;
        }*/

        public static List<TiposDePersonas> GetList(Expression<Func<TiposDePersonas, bool>> criterioBusqueda)
        {
            List<TiposDePersonas> tdp = new List<TiposDePersonas>();
            Contexto contex = new Contexto();
            try
            {
                tdp = contex.TipoDePersona.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return tdp;
        }
    }
}
