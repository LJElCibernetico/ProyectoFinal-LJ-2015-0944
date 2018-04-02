using ProyectoFinal_2015_0944.BLL;
using ProyectoFinal_2015_0944.Consultas;
using ProyectoFinal_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_2015_0944.Registros
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            Expression<Func<Departamentos, bool>> filtrar = x => true;
            List<Departamentos> tipo = new List<Departamentos>();
            tipo = DepartamentosBLL.GetList(filtrar);

            foreach (var tel in tipo)
            {
                DepartamentoComboBox.Items.Add(tel.Departamento);

            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            IDNumericUpDown.Value = 0;
            DepartamentoComboBox.Text = String.Empty;
            NombreTextBox.Text = String.Empty;
            PrecioNumericUpDown.Value = 0;
            ExistenciaNumericUpDown.Value = 0;
            CaducidadDateTimePicker.Value = DateTime.Now;
            CostoNumericUpDown.Value = 0;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);
            Productos persona = ProductosBLL.Buscar(ID);

            if (persona == null)
            {
                Productos p1 = LlenarClase();
                if (NombreTextBox.Text == String.Empty || DepartamentoComboBox.Text == String.Empty
                   || PrecioNumericUpDown.Value == 0 || ExistenciaNumericUpDown.Value == 0
                   || CaducidadDateTimePicker.Text == String.Empty || CostoNumericUpDown.Value == 0)
                    errorProvider1.SetError(GuardarButton, "No puede dejar nada vacio");
                else if (ProductosBLL.Guardar(p1))
                    MessageBox.Show("Producto Guardado");
                else if (!ProductosBLL.Guardar(p1))
                    MessageBox.Show("Este Producto No Pudo Ser Guardado");
            }
            else
            {
                Edit(persona);
                if (ProductosBLL.Modificar(persona))
                    MessageBox.Show("Acaba de Modificar Este Producto");
                else
                    MessageBox.Show("No Se Pudo Modificar Este Producto");
            }
            ClearAll();
        }

        private Productos LlenarClase()
        {
            Productos producto = new Productos();
            
            producto.IdProducto = int.Parse(IDNumericUpDown.Text);
            producto.IdDepartamento = (DepartamentoComboBox.SelectedIndex + 1);
            producto.Nombre = NombreTextBox.Text;
            producto.Precio = Double.Parse(PrecioNumericUpDown.Text);
            producto.Existencia = int.Parse(ExistenciaNumericUpDown.Text);
            producto.FechaDeVencimiento = CaducidadDateTimePicker.Value;
            producto.Costo = Double.Parse(CostoNumericUpDown.Text);

            return producto;
        }

        private void Edit(Productos p)
        {
            p.IdDepartamento = (DepartamentoComboBox.SelectedIndex + 1);
            p.Nombre = NombreTextBox.Text;
            p.Precio = Double.Parse(PrecioNumericUpDown.Text);
            p.Existencia = int.Parse(ExistenciaNumericUpDown.Text);
            p.FechaDeVencimiento = CaducidadDateTimePicker.Value;
            p.Costo = Double.Parse(CostoNumericUpDown.Text);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);

            if (ProductosBLL.Eliminar(ID))
            {
                MessageBox.Show("Producto Eliminado");
            }
            else
            {
                errorProvider1.SetError(EliminarButton, "No se puede eliminar un Producto que no existe");
            }
            ClearAll();
        }

        private void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);
            Productos Producto = new Productos();
            Departamentos depa = new Departamentos();

            Producto = ProductosBLL.Buscar(ID);

            if (Producto != null)
            {
                MessageBox.Show("Producto Encontrado");
                Search(Producto);

                if (DepartamentosBLL.Buscar(Producto.IdDepartamento) != null)
                {
                    depa = DepartamentosBLL.Buscar(Producto.IdDepartamento);
                    DepartamentoComboBox.Text = depa.Departamento;
                }
            }
            else
            {
                MessageBox.Show("Producto No encontado");
            }
        }

        private void Search(Productos p1)
        {
            DepartamentoComboBox.Text = (p1.IdDepartamento).ToString();
            NombreTextBox.Text = p1.Nombre;
            PrecioNumericUpDown.Text = (p1.Precio).ToString();
            ExistenciaNumericUpDown.Text = (p1.Existencia).ToString();
            CaducidadDateTimePicker.Value = p1.FechaDeVencimiento;
            CostoNumericUpDown.Text = (p1.Costo).ToString();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            cProductos cp = new cProductos();
            cp.Show();
        }

        private void DepartamentoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
