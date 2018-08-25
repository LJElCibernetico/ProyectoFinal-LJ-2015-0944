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
    public class PersonasBLL
    {
        public static bool Guardar(Personas persona)
        {
            bool paso = false;
            try
            {
                Contexto Contex = new Contexto();
                Contex.Persona.Add(persona);
                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Personas persona)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Entry(persona).State = EntityState.Modified;
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

                var p = contex.Persona.Find(Id);

                contex.Persona.Remove(p);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Personas Buscar(int Id)
        {
            Personas persona = new Personas();

            try
            {
                Contexto contex = new Contexto();
                persona = contex.Persona.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return persona;
        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> criterioBusqueda)
        {
            List<Personas> Persona = new List<Personas>();
            try
            {
                Contexto contex = new Contexto();
                Persona = contex.Persona.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return Persona;
        }
    }
}
