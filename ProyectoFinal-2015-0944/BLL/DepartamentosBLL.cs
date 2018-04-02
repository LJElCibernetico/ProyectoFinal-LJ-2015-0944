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
    public class DepartamentosBLL
    {
        public static bool Guardar(Departamentos departamento)
        {
            bool paso = false;
            try
            {
                Contexto Contex = new Contexto();
                Contex.Departamento.Add(departamento);
                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Departamentos departamento)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Entry(departamento).State = EntityState.Modified;
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

                var departamento = contex.Departamento.Find(Id);

                contex.Departamento.Remove(departamento);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Departamentos Buscar(int Id)
        {
            Departamentos Departamento = new Departamentos();

            try
            {
                Contexto contex = new Contexto();
                Departamento = contex.Departamento.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return Departamento;
        }

        public static List<Departamentos> GetList(Expression<Func<Departamentos, bool>> criterioBusqueda)
        {
            List<Departamentos> Departamento = new List<Departamentos>();
            try
            {
                Contexto contex = new Contexto();
                Departamento = contex.Departamento.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return Departamento;
        }
    }
}
