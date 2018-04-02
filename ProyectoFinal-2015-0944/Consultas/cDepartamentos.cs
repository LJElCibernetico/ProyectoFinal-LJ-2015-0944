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
    public partial class cDepartamentos : Form
    {
        public cDepartamentos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Expression<Func<Departamentos, bool>> filtrar = x => true;
            if (FiltrarComboBox.SelectedIndex == 0)
            {
                id = int.Parse(CriterioTextBox.Text);
                filtrar = t => t.IdDepartamento == id;
            }
            else if (FiltrarComboBox.SelectedIndex == 1)
                filtrar = t => t.Departamento.Contains(CriterioTextBox.Text);

            TiposDePersonasDataGridView.DataSource = DepartamentosBLL.GetList(filtrar);
        }
    }
}
