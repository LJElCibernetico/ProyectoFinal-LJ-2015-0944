using ProyectoFinal_2015_0944.BLL;
using ProyectoFinal_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoFinal_Web.pages.Registros
{
    public partial class rTiposDePersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            TextBoxID.Text = String.Empty;
            TextBoxTipo.Text = String.Empty;
        }

        protected void ButtonBuscar_Click1(object sender, EventArgs e)
        {
            int ID = int.Parse(TextBoxID.Text);
            TiposDePersonas tdp = new TiposDePersonas();

            tdp = TiposDePersonasBLL.Buscar(ID);

            if (tdp != null)
            {
                MessageBox.Show("Tipo de Persona Encontada");
                TextBoxTipo.Text = tdp.Tipo;
            }
            else
            {
                MessageBox.Show("Tipo de Persona No Encontada");
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(TextBoxID.Text);

            if (TiposDePersonasBLL.Eliminar(ID))
            {
                MessageBox.Show("Tipo de Persona Eliminada");
            }
            else
            {
                MessageBox.Show("No se puede eliminar un Tipo de Persona que no existe");
            }
            ClearAll();
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(TextBoxID.Text, out ID);
            TiposDePersonas tdp = TiposDePersonasBLL.Buscar(ID);

            if (TextBoxTipo.Text == String.Empty)
                MessageBox.Show("Solo el ID se puede dejar vacio");
            else if (tdp == null)
            {
                TiposDePersonas tdp1 = LlenarClase();
                
                if (TiposDePersonasBLL.Guardar(tdp1))
                    MessageBox.Show("Tipo de Persona Guardada");
                else 
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
            tdp.Tipo = TextBoxTipo.Text;

            return tdp;
        }

        private void edit(TiposDePersonas tdp)
        {
            tdp.IdTipoDePersona = int.Parse(TextBoxID.Text);
            tdp.Tipo = TextBoxTipo.Text;
        }
    }
}