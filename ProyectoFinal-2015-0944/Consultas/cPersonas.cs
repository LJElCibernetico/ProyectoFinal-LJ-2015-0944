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
    public partial class cPersonas : Form
    {
        public cPersonas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Expression<Func<Personas, bool>> filtrar = x => true;
            if (FiltrarComboBox.SelectedIndex == 0) 
            {
                id = int.Parse(CriterioTextBox.Text);
                filtrar = t => t.IdPersona == id;
            }
            else if (FiltrarComboBox.SelectedIndex == 1)
                filtrar = t => t.Nombre.Contains(CriterioTextBox.Text);
            else if(FiltrarComboBox.SelectedIndex == 2)
                filtrar = t => t.Apellido.Contains(CriterioTextBox.Text);
            else if(FiltrarComboBox.SelectedIndex == 3)
                filtrar = t => t.Telefono.Contains(CriterioTextBox.Text);
            else if(FiltrarComboBox.SelectedIndex == 4)
                filtrar = t => t.Direccion.Contains(CriterioTextBox.Text);
            else if(FiltrarComboBox.SelectedIndex == 5)
                filtrar = t => t.Email.Contains(CriterioTextBox.Text);

            TiposDePersonasDataGridView.DataSource = PersonasBLL.GetList(filtrar);
        }
    }
}
