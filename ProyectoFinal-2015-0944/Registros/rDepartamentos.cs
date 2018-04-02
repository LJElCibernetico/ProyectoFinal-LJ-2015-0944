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
    public partial class rDepartamentos : Form
    {
        public rDepartamentos()
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
            DepartamentoTextBox.Text = String.Empty;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);
            Departamentos depa = DepartamentosBLL.Buscar(ID);

            if (depa == null)
            {
                Departamentos depa1 = LlenarClase();
                if (DepartamentoTextBox.Text == String.Empty)
                    errorProvider1.SetError(GuardarButton, "No puede dejar nada vacio");
                else if (DepartamentosBLL.Guardar(depa1))
                    MessageBox.Show("Departamento Guardado");
                else if (!DepartamentosBLL.Guardar(depa1))
                    MessageBox.Show("Este Departamento No Pudo Ser Guardado");
            }
            else
            {
                edit(depa);
                if (DepartamentosBLL.Modificar(depa))
                    MessageBox.Show("Acaba de Modificar Este Departamento");
                else
                    MessageBox.Show("No Se Pudo Modificar Este Departamento");
            }
            ClearAll();
        }

        private Departamentos LlenarClase()
        {
            Departamentos departamento = new Departamentos();
            int a = int.Parse(IDNumericUpDown.Text);
            departamento.IdDepartamento = a;
            departamento.Departamento = DepartamentoTextBox.Text;

            return departamento;
        }

        private void edit(Departamentos depa)
        {
            depa.IdDepartamento = int.Parse(IDNumericUpDown.Text);
            depa.Departamento = DepartamentoTextBox.Text;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);
            Departamentos depa = new Departamentos();

            depa = DepartamentosBLL.Buscar(ID);

            if (depa != null)
            {
                MessageBox.Show("Departamento Encontado");
                DepartamentoTextBox.Text = depa.Departamento;
            }
            else
            {
                MessageBox.Show("Departamento No Encontado");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);

            if (DepartamentosBLL.Eliminar(ID))
            {
                MessageBox.Show("Departamento Eliminado");
            }
            else
            {
                errorProvider1.SetError(EliminarButton, "No se puede eliminar un Departamento que no existe");
            }
            ClearAll();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            cDepartamentos cd = new cDepartamentos();
            cd.Show();
        }
    }
}
