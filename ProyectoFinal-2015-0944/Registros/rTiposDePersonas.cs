using ProyectoFinal_2015_0944.BLL;
using ProyectoFinal_2015_0944.Consultas;
using ProyectoFinal_2015_0944.Entidades;
using ProyectoFinal_2015_0944.Menu;
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
    public partial class rTiposDePersonas : Form
    {
        public rTiposDePersonas()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            IDNumericUpDown.Value = 0;
            TipoTextBox.Text = String.Empty;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(IDNumericUpDown.Text, out ID);
            TiposDePersonas tdp = TiposDePersonasBLL.Buscar(ID);

            if (tdp == null)
            {
                TiposDePersonas tdp1 = LlenarClase();
                if (TipoTextBox.Text == String.Empty)
                    errorProvider1.SetError(GuardarButton, "No puede dejar nada vacio");
                else if (TiposDePersonasBLL.Guardar(tdp1))
                    MessageBox.Show("Tipo de Persona Guardada");
                else if (!TiposDePersonasBLL.Guardar(tdp1))
                    MessageBox.Show("Este Tipo de Persona No Pudo Ser Guardada");
            }
            else
            {
                edit(tdp);
                if (TiposDePersonasBLL.Modificar(tdp))
                    MessageBox.Show("Acaba de Modificar Este Tipo de Persona");
                else
                    MessageBox.Show("No Se Pudo Modificar Este Tipo de Persona");
            }
            ClearAll();
        }

        private TiposDePersonas LlenarClase()
        {
            TiposDePersonas tdp = new TiposDePersonas();
            int a = int.Parse(IDNumericUpDown.Text);
            tdp.IdTipoDePersona = a;
            tdp.Tipo = TipoTextBox.Text;

            return tdp;
        }

        private void edit(TiposDePersonas tdp)
        {
            tdp.IdTipoDePersona = int.Parse(IDNumericUpDown.Text);
            tdp.Tipo = TipoTextBox.Text;
        }

        private void BuscarTipoDePersonaButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);
            TiposDePersonas tdp = new TiposDePersonas();

            tdp = TiposDePersonasBLL.Buscar(ID);

            if (tdp != null)
            {
                MessageBox.Show("Tipo de Persona Encontada");
                TipoTextBox.Text = tdp.Tipo;
            }
            else
            {
                MessageBox.Show("Tipo de Persona No Encontada");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);

            if (TiposDePersonasBLL.Eliminar(ID))
            {
                MessageBox.Show("Tipo de Persona Eliminada");
            }
            else
            {
                errorProvider1.SetError(EliminarButton, "No se puede eliminar un Tipo de Persona que no existe");
            }
            ClearAll();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            cTiposDePersonas ctdp = new cTiposDePersonas();
            ctdp.Show();
        }
    }
}
