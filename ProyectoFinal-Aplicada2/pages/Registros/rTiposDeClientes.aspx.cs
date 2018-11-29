using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Aplicada2.pages.Registros
{
    public partial class rTiposDeClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            TextBoxTipoClienteID.Text = String.Empty;
            TextBoxTipoCliente.Text = String.Empty;
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            RepositorioBase<TiposDeClientes> tipoClienteRepository = new RepositorioBase<TiposDeClientes>();
            TiposDeClientes tipoCliente = tipoClienteRepository.Buscar(int.Parse(TextBoxTipoClienteID.Text));

            if (tipoCliente != null)
            {
                TextBoxTipoCliente.Text = tipoCliente.Tipo;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Tipo de Cliente Encontrado');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Tipo de Cliente no Encontrado');", addScriptTags: true);
            }
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                RepositorioBase<TiposDeClientes> tipoCliente = new RepositorioBase<TiposDeClientes>();

                int id;

                if (TextBoxTipoClienteID.Text == String.Empty)
                    id = 0;
                else
                    id = int.Parse(TextBoxTipoClienteID.Text);


                if (id == 0)
                {
                    if (tipoCliente.Guardar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Tipo de Cliente Guardado');", addScriptTags: true);
                    ClearAll();
                }
                else
                {
                    if (tipoCliente.Modificar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Tipo de Cliente Moficado');", addScriptTags: true);
                    ClearAll();
                }
            }
        }

        private TiposDeClientes LlenaClase()
        {
            int id;
            if (TextBoxTipoClienteID.Text == String.Empty)
                id = 0;
            else
                id = int.Parse(TextBoxTipoClienteID.Text);
            return new TiposDeClientes(
                id,
                TextBoxTipoCliente.Text
                );
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            RepositorioBase<TiposDeClientes> tipoClienteRepository = new RepositorioBase<TiposDeClientes>();
            TiposDeClientes tipoCliente = tipoClienteRepository.Buscar(int.Parse(TextBoxTipoClienteID.Text));

            if (tipoCliente != null)
            {
                tipoClienteRepository.Eliminar(int.Parse(TextBoxTipoClienteID.Text));
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Tipo de Cliente Eliminado');", addScriptTags: true);
                ClearAll();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se puede borrar un tipo de cliente que no existe');", addScriptTags: true);
            }
        }
    }
}