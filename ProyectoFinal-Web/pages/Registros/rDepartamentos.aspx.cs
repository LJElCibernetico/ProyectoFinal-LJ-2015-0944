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
    public partial class rDepartamentos : System.Web.UI.Page
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
            TextBoxDep.Text = String.Empty;
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(TextBoxID.Text, out ID);
            Departamentos tdp = DepartamentosBLL.Buscar(ID);

            if (TextBoxDep.Text == String.Empty)
                MessageBox.Show("Solo el ID se puede dejar vacio");
            else if (tdp == null)
            {
                Departamentos tdp1 = LlenarClase();

                if (DepartamentosBLL.Guardar(tdp1))
                    MessageBox.Show("Departamento Guardado");
                else
                    MessageBox.Show("Este Departamento No Pudo Ser Guardado");
            }
            else
            {
                edit(tdp);
                if (DepartamentosBLL.Modificar(tdp))
                    MessageBox.Show("Acaba de Modificar Este Departamento");
                else
                    MessageBox.Show("No Se Pudo Modificar Este Departamento");
            }
            ClearAll();
        }

        private Departamentos LlenarClase()
        {
            Departamentos tdp = new Departamentos();
            tdp.Departamento = TextBoxDep.Text;

            return tdp;
        }

        private void edit(Departamentos tdp)
        {
            tdp.IdDepartamento = int.Parse(TextBoxID.Text);
            tdp.Departamento = TextBoxDep.Text;
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(TextBoxID.Text);

            if (DepartamentosBLL.Eliminar(ID))
            {
                MessageBox.Show("Departamento Eliminada");
            }
            else
            {
                MessageBox.Show("No se puede eliminar un Departamento que no existe");
            }
            ClearAll();
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(TextBoxID.Text);
            Departamentos tdp = new Departamentos();

            tdp = DepartamentosBLL.Buscar(ID);

            if (tdp != null)
            {
                MessageBox.Show("Departamento Encontado");
                TextBoxDep.Text = tdp.Departamento;
            }
            else
            {
                MessageBox.Show("Departamento No Encontado");
            }
        }
    }
}