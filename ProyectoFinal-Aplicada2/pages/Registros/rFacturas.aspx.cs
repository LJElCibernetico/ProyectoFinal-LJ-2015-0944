using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace ProyectoFinal_Aplicada2.pages.Registros
{
    public partial class rFacturas : System.Web.UI.Page
    {
        List<FacturaDetalle> detalle = new List<FacturaDetalle>();
        double total;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> producto = new RepositorioBase<Productos>();
            FacturaDetalle facdetalle = new FacturaDetalle();

            var buscar = producto.Buscar(int.Parse(TextBoxProductoID.Text));
            facdetalle.NombreProducto = buscar.Nombre;
            facdetalle.Precio = buscar.Precio;
            facdetalle.Importe = facdetalle.Precio * int.Parse(TextBoxCantidadProducto.Text);
            facdetalle.IdProducto = int.Parse(TextBoxProductoID.Text);
            facdetalle.Cantidad = int.Parse(TextBoxCantidadProducto.Text);


            total += facdetalle.Importe;

            TextBoxTotal.Text = total.ToString();

            detalle.Add(facdetalle);
            FacturaGridView.DataSource = detalle;
            FacturaGridView.DataBind();
        }

        protected void ButtonBuscarFactura_Click(object sender, EventArgs e)
        {
            RepositorioBase<Facturas> facturaRepository = new RepositorioBase<Facturas>();
            Facturas facturas = facturaRepository.Buscar(int.Parse(TextBoxFacturaID.Text));

            if (facturas != null)
            {
                LlenarCamposFactura(facturas);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Producto Encontrado');", addScriptTags: true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Producto no Encontrado');", addScriptTags: true);
            }
        }

        private void LlenarCamposFactura(Facturas facturas)
        {
            TextBoxClienteID.Text = facturas.IdCliente.ToString();
            TextBoxProductoID.Text = facturas.IdProducto.ToString();
            TextBoxFecha.Text = facturas.Fecha.ToString("yyyy-MM-dd");
            TextBoxComentario.Text = facturas.Observacion;
            TextBoxTotal.Text = facturas.Monto.ToString();
            FacturaGridView.DataSource = facturas.Lista;
            FacturaGridView.DataBind();
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            TextBoxClienteID.Text = String.Empty;
            TextBoxProductoID.Text = String.Empty;
            TextBoxFecha.Text = String.Empty;
            TextBoxComentario.Text = String.Empty;
            TextBoxTotal.Text = String.Empty;
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                RepositorioBase<Facturas> rb = new RepositorioBase<Facturas>();

                int id = 0;

                if (ComprobarID(id) == 0)
                {
                    if (rb.Guardar(LlenaClase()))
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Facturas Guardada');", addScriptTags: true);
                        ClearAll();
                        total = 0;
                    }

                }
                else
                {
                    if (rb.Modificar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Factura Modificada');", addScriptTags: true);
                    ClearAll();
                }
            }
        }

        private Facturas LlenaClase()
        {
            int id = 0;
            return new Facturas(
                ComprobarID(id),
                int.Parse(TextBoxClienteID.Text),
                int.Parse(TextBoxProductoID.Text),
                Convert.ToDateTime(TextBoxFecha.Text),
                double.Parse(TextBoxTotal.Text),
                TextBoxComentario.Text,
                detalle
                );
        }

        private int ComprobarID(int id)
        {
            if (TextBoxFacturaID.Text == String.Empty)
                id = 0;
            else
                id = int.Parse(TextBoxFacturaID.Text);
            return id;
        }
    }
}