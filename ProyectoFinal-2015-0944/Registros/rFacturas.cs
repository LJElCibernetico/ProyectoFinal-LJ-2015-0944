using ProyectoFinal_2015_0944.BLL;
using ProyectoFinal_2015_0944.Consultas;
using ProyectoFinal_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_2015_0944.Registros
{
    public partial class rFacturas : Form
    {
        List<FacturaDetalle> p = new List<FacturaDetalle>();

        public rFacturas()
        {
            InitializeComponent();
        }

        private void BuscarPersonaButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IdPersonasNumericUpDown.Text);
            Personas Persona = new Personas();

            Persona = PersonasBLL.Buscar(ID);

            if (Persona != null)
            {
                MessageBox.Show("Persona Encontrada");
                search(Persona);
            }
            else
            {
                MessageBox.Show("Persona No encontada");
            }
        }

        private void search(Personas p1)
        {
            TipoDePersonaTextBox.Text = (p1.IdTipoDePersona).ToString();
            NombreTextBox.Text = p1.Nombre;
            TelefonoTextBox.Text = p1.Telefono;
            DireccionTextBox.Text = p1.Direccion;
        }

        private void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IdProductoNumericUpDown.Text);
            Productos Producto = new Productos();

            Producto = ProductosBLL.Buscar(ID);

            if (Producto != null)
            {
                MessageBox.Show("Producto Encontrado");
                PrecioTextBox.Text = (Producto.Precio).ToString();
            }
            else
            {
                MessageBox.Show("Producto No encontado");
            }
        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double a = (double) CantidadNumericUpDown.Value;
            double b = Double.Parse(PrecioTextBox.Text);
            ImporteTextBox.Text = (a * b).ToString();
        }

        private void BuscarFacturaButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);
            Facturas Factura = new Facturas();
            FacturaDetalle Detalle = new FacturaDetalle();

            Factura = FacturaDetalleBLL.Buscar(ID);

            if (Factura != null)
            {
                MessageBox.Show("Factura Encontrada");
                IdPersonasNumericUpDown.Value = Factura.IdPersona;
                IdProductoNumericUpDown.Value = Detalle.IdProducto;
                FechadateTimePicker.Value = Factura.Fecha;
                ObservacionTextBox.Text = Factura.Observacion;
                MontoTextBox.Text = (Factura.Monto).ToString();
                FacturaDataGridView.DataSource = FacturaDetalleBLL.GetList(X => X.IdFactura == (int)IDNumericUpDown.Value);
                IdProductoNumericUpDown.Value = Detalle.IdProducto;
            }
            else
            {
                MessageBox.Show("Factura No encontada");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            p.Add(new FacturaDetalle
                (
                    0,
                    (int)IDNumericUpDown.Value,
                    (int)IdProductoNumericUpDown.Value,
                    (int)CantidadNumericUpDown.Value,
                    double.Parse(PrecioTextBox.Text),
                    double.Parse(ImporteTextBox.Text)
                ));
            foreach(var f in p)
            {
                total += f.Importe;
            }
            FacturaDataGridView.DataSource = p.ToList();
            MontoTextBox.Text = total.ToString();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(IDNumericUpDown.Text, out ID);
            Facturas f1 = FacturaDetalleBLL.Buscar(ID);

            if (f1 == null)
            {
                Facturas f = LlenarClase();
                if (FacturaDetalleBLL.Guardar(f))
                    MessageBox.Show("Factura Guardada");
                else if (!FacturaDetalleBLL.Guardar(f))
                    MessageBox.Show("Esta Factura No Pudo Ser Guardada");
            }
            else
            {
                edit(f1);
                if (FacturaDetalleBLL.Modificar(f1))
                    MessageBox.Show("Acaba de Modificar Esta Persona");
                else
                    MessageBox.Show("No Se Pudo Modificar Esta Persona");
            }
            ClearAll();
        }

        private Facturas LlenarClase()
        {
            Facturas f = new Facturas();
            int a,b,c;

            int.TryParse(IDNumericUpDown.Text, out a);
            f.IdFactura = a;
            int.TryParse(IdPersonasNumericUpDown.Text, out b);
            f.IdPersona = b;
            f.Monto = double.Parse(MontoTextBox.Text);
            f.Observacion = ObservacionTextBox.Text;
            f.Fecha = FechadateTimePicker.Value;
            f.Lista = p;

            return f;
        }

        private void edit(Facturas f)
        {
            f.IdPersona = (int)IdPersonasNumericUpDown.Value;
            f.Monto = double.Parse(MontoTextBox.Text);
            f.Observacion = ObservacionTextBox.Text;
            f.Fecha = FechadateTimePicker.Value;
            f.Lista = p;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearAll()
        {
            IDNumericUpDown.Value = 0;
            IdPersonasNumericUpDown.Value = 0;
            IdProductoNumericUpDown.Value = 0;
            CantidadNumericUpDown.Value = 0;
            NombreTextBox.Text = String.Empty;
            TelefonoTextBox.Text = String.Empty;
            TipoDePersonaTextBox.Text = String.Empty;
            TelefonoTextBox.Text = String.Empty;
            DireccionTextBox.Text = String.Empty;
            ImporteTextBox.Text = String.Empty;
            PrecioTextBox.Text = String.Empty;
            ObservacionTextBox.Text = String.Empty;
            MontoTextBox.Text = String.Empty;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);

            if (FacturaDetalleBLL.Eliminar(ID))
            {
                MessageBox.Show("Factura Eliminada");
            }
            else
            {
                errorProvider1.SetError(EliminarButton, "No se puede eliminar una Factura que no existe");
            }
            ClearAll();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            cFacturas cf = new cFacturas();
            cf.Show();
        }
    }
}
