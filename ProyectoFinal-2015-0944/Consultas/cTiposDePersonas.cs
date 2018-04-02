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
    public partial class cTiposDePersonas : Form
    {
        public cTiposDePersonas()
        {
            InitializeComponent();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Expression<Func<TiposDePersonas, bool>> filtrar = x => true;
            if(FiltrarComboBox.SelectedIndex == 0)
            {
                id = int.Parse(CriterioTextBox.Text);
                filtrar = t => t.IdTipoDePersona == id;
            }
            else if(FiltrarComboBox.SelectedIndex == 1)
                filtrar = t => t.Tipo.Contains(CriterioTextBox.Text);

            TiposDePersonasDataGridView.DataSource = TiposDePersonasBLL.GetList(filtrar);
        }
    }
}
