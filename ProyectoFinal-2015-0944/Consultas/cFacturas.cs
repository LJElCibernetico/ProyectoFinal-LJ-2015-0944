using ProyectoFinal_2015_0944.BLL;
using ProyectoFinal_2015_0944.Entidades;
using ProyectoFinal_2015_0944.Reportes;
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
    public partial class cFacturas : Form
    {
        Expression<Func<Facturas, bool>> filtrar = x => true;
        public cFacturas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            double p;

            if (FiltrarComboBox.SelectedIndex == 0)
            {
                id = int.Parse(CriterioTextBox.Text);
                filtrar = t => t.IdFactura == id;
            }
            else if (FiltrarComboBox.SelectedIndex == 1)
                filtrar = t => t.Observacion.Contains(CriterioTextBox.Text);
            else if (FiltrarComboBox.SelectedIndex == 2)
            {
                p = double.Parse(CriterioTextBox.Text);
                filtrar = t => t.Monto == p;
            }
            else if (FiltrarComboBox.SelectedIndex == 3)
                filtrar = t => (t.Fecha >= FechaInicialDateTimePicker.Value) && (t.Fecha <= FechaFinalDateTimePicker.Value);
           
            TiposDePersonasDataGridView.DataSource = FacturaDetalleBLL.GetList1(filtrar);
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ImprimirFacturas ifac = new ImprimirFacturas(FacturaDetalleBLL.GetList1(filtrar));
            ifac.Show();
        }
    }
}
