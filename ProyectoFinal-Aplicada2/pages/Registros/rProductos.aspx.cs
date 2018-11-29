using BLL;
using Entidades;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Aplicada2.pages.Registros
{
    public partial class rProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListDepartamentos();
            }
            TextBoxFechaVencimiento.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void ListDepartamentos()
        {
            RepositorioBase<Departamentos> rep = new RepositorioBase<Departamentos>();
            DropDownListDepartamentos.DataSource = rep.GetList(x => true);
            DropDownListDepartamentos.DataValueField = "IdDepartamento";
            DropDownListDepartamentos.DataTextField = "Departamento";
            DropDownListDepartamentos.DataBind();
            DropDownListDepartamentos.Items.Insert(0, new ListItem("", ""));
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            TextBoxProductoID.Text = String.Empty;
            DropDownListDepartamentos.Text = String.Empty;
            TextBoxNombreProducto.Text = String.Empty;
            TextBoxFechaVencimiento.Text = String.Empty;
            TextBoxCosto.Text = String.Empty;
            TextBoxExistencia.Text = String.Empty;
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> productoRepository = new RepositorioBase<Productos>();
            Productos producto = productoRepository.Buscar(int.Parse(TextBoxProductoID.Text));

            if (producto != null)
            {
                LlenarCampos(producto);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Producto Encontrado');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Producto no Encontrado');", addScriptTags: true);
            }
        }

        private void LlenarCampos(Productos producto)
        {
            DropDownListDepartamentos.Text = producto.IdDepartamento.ToString();
            TextBoxNombreProducto.Text = producto.Nombre;
            TextBoxFechaVencimiento.Text = producto.FechaDeVencimiento.ToString("yyyy-MM-dd");
            TextBoxCosto.Text = producto.Costo.ToString();
            TextBoxExistencia.Text = producto.Existencia.ToString();
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                RepositorioBase<Productos> rb = new RepositorioBase<Productos>();

                double.TryParse(TextBoxCosto.Text, out double costo);
                double.TryParse(TextBoxPrecio.Text, out double precio);

                int id = 0;

                if (costo < precio)
                {
                    if (ComprobarID(id) == 0)
                    {
                        if (rb.Guardar(LlenaClase()))
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Producto Guardado');", addScriptTags: true);
                        ClearAll();
                    }
                    else
                    {
                        if (rb.Modificar(LlenaClase()))
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Producto Modificado');", addScriptTags: true);
                        ClearAll();
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Recuerde que el costo debe ser menor que el precio');", addScriptTags: true);
                }
            }
        }

        private int ComprobarID(int id)
        {
            if (TextBoxProductoID.Text == String.Empty)
                id = 0;
            else
                id = int.Parse(TextBoxProductoID.Text);
            return id;
        }

        private Productos LlenaClase()
        {
            int id = 0;
            return new Productos(
                    ComprobarID(id),
                    int.Parse(DropDownListDepartamentos.SelectedValue),
                    TextBoxNombreProducto.Text,
                    double.Parse(TextBoxPrecio.Text),
                    int.Parse(TextBoxExistencia.Text),
                    Convert.ToDateTime(TextBoxFechaVencimiento.Text),
                    double.Parse(TextBoxCosto.Text)
                );
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> productoRepository = new RepositorioBase<Productos>();
            Productos producto = productoRepository.Buscar(int.Parse(TextBoxProductoID.Text));

            int.TryParse(TextBoxProductoID.Text, out int id);

            if (producto != null)
            {
                productoRepository.Eliminar(int.Parse(TextBoxProductoID.Text));
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Producto Eliminado');", addScriptTags: true);
                ClearAll();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se puede eliminar un producto que no existe');", addScriptTags: true);
            }
        }
    }
}