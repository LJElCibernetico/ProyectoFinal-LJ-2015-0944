using ProyectoFinal_2015_0944.BLL;
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

namespace ProyectoFinal_2015_0944.Consultas
{
    public partial class cProductos : Form
    {
        public cProductos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            double p;
            Expression<Func<Productos, bool>> filtrar = x => true;
            if (FiltrarComboBox.SelectedIndex == 0)
            {
                id = int.Parse(CriterioTextBox.Text);
                filtrar = t => t.IdProducto == id;
            }
            else if (FiltrarComboBox.SelectedIndex == 1)
                filtrar = t => t.Nombre.Contains(CriterioTextBox.Text);
            else if (FiltrarComboBox.SelectedIndex == 2)
            {
                p = double.Parse(CriterioTextBox.Text);
                filtrar = t => t.Precio == p;
            }
            else if (FiltrarComboBox.SelectedIndex == 3)
            {
                id = int.Parse(CriterioTextBox.Text);
                filtrar = t => t.Existencia == id;
            }
                
            else if (FiltrarComboBox.SelectedIndex == 4)
                filtrar = t => (t.FechaDeVencimiento >= FechaInicialDateTimePicker.Value) && (t.FechaDeVencimiento <= FechaFinalDateTimePicker.Value);
            else if (FiltrarComboBox.SelectedIndex == 5)
            {
                p = double.Parse(CriterioTextBox.Text);
                filtrar = t => t.Costo == p;
            }
                

            TiposDePersonasDataGridView.DataSource = ProductosBLL.GetList(filtrar);
        }
    }
}
