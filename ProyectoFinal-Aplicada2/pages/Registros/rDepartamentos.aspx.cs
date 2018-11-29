using BLL;
using Entidades;
using System;
using System.Web.UI;

namespace ProyectoFinal_Aplicada2.pages.Registros
{
    public partial class rDepartamentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            TextBoxDepartamentoID.Text = String.Empty;
            TextBoxDescripcion.Text = String.Empty;
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Departamentos> rd = new RepositorioBase<Departamentos>();
            Departamentos d = rd.Buscar(int.Parse(TextBoxDepartamentoID.Text));

            if (d != null)
            {
                TextBoxDescripcion.Text = d.Departamento;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Departamento Encontrado');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Departamento no Encontrado');", addScriptTags: true);
            }
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                RepositorioBase<Departamentos> departamento = new RepositorioBase<Departamentos>();

                int id = 0;

                if (ComprobarID(id) == 0)
                {
                    if (departamento.Guardar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Departamento Guardado');", addScriptTags: true);
                    ClearAll();
                }
                else
                {
                    if (departamento.Modificar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Departamento Modificado');", addScriptTags: true);
                    ClearAll();
                }
            }
        }

        private int ComprobarID(int id)
        {
            if (TextBoxDepartamentoID.Text == String.Empty)
                id = 0;
            else
                id = int.Parse(TextBoxDepartamentoID.Text);
            return id;
        }

        private Departamentos LlenaClase()
        {
            int id = 0;
            return new Departamentos(
                ComprobarID(id),
                TextBoxDescripcion.Text
                );
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Departamentos> d = new RepositorioBase<Departamentos>();
            Departamentos d1 = d.Buscar(int.Parse(TextBoxDepartamentoID.Text));

            if (d1 != null)
            {
                d.Eliminar(int.Parse(TextBoxDepartamentoID.Text));
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Departamento Eliminado');", addScriptTags: true);
                ClearAll();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se puede eliminar un departamento que no existe');", addScriptTags: true);
            }
        }
    }
}