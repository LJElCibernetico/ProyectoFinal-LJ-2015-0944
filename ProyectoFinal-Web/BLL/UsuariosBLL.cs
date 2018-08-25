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
    public class UsuariosBLL
    {
        public static EntityState EntryState { get; private set; }

        public static bool Guardar(Usuarios Usuario)
        {
            bool paso = false;
            Contexto contex = new Contexto();
            try
            {
                if (contex.Usuario.Add(Usuario) != null)
                {
                    contex.SaveChanges();
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
            Contexto contex = new Contexto();
            try
            {
                var eliminar = contex.Usuario.Find(Id);
                contex.Entry(eliminar).State = EntityState.Deleted;
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

        public static bool Modificar(Usuarios user)
        {
            bool paso = false;
            Contexto contex = new Contexto();
            try
            {
                contex.Entry(user).State = EntityState.Modified;
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

        public static Usuarios Buscar(int id)
        {
            Usuarios usuario = new Usuarios();
            Contexto contex = new Contexto();
            try
            {
                usuario = contex.Usuario.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return usuario;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> user)
        {
            List<Usuarios> usuario = new List<Usuarios>();
            Contexto contex = new Contexto();
            try
            {
                usuario = contex.Usuario.Where(user).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return usuario;
        }
    }
}
