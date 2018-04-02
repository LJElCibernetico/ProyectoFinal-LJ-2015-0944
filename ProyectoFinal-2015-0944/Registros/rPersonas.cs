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
    public partial class rPersonas : Form
    {
        public rPersonas()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            Expression<Func<TiposDePersonas, bool>> filtrar = x => true;
            List<TiposDePersonas> tipo = new List<TiposDePersonas>();
            tipo = TiposDePersonasBLL.GetList(filtrar);

            foreach (var t in tipo)
            {
                TipoDePersonaComboBox.Items.Add(t.Tipo);

            }
        }

        private void ClearAll()
        {
            IDNumericUpDown.Value = 0;
            TipoDePersonaComboBox.Text = String.Empty;
            NombreTextBox.Text = String.Empty;
            ApellidoTextBox.Text = String.Empty;
            TelefonoTextBox.Text = String.Empty;
            DireccionTextBox.Text = String.Empty;
            EmailTextBox.Text = String.Empty;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(IDNumericUpDown.Text, out ID);
            Personas persona = PersonasBLL.Buscar(ID);

            if(persona == null)
            {
                Personas p1 = LlenarClase();
                if (NombreTextBox.Text == String.Empty || ApellidoTextBox.Text == String.Empty
                   || TelefonoTextBox.Text == String.Empty || EmailTextBox.Text == String.Empty
                   || DireccionTextBox.Text == String.Empty || TipoDePersonaComboBox.Text == String.Empty)
                    errorProvider1.SetError(GuardarButton, "No puede dejar nada vacio");
                else if (PersonasBLL.Guardar(p1))
                    MessageBox.Show("Persona Guardada");
                else if (!PersonasBLL.Guardar(p1))
                    MessageBox.Show("Esta Persona No Pudo Ser Guardada");
            }
            else
            {
                edit(persona);
                if (PersonasBLL.Modificar(persona))
                    MessageBox.Show("Acaba de Modificar Esta Persona");
                else
                    MessageBox.Show("No Se Pudo Modificar Esta Persona");
            }
            ClearAll();
        }

        private Personas LlenarClase()
        {
            Personas persona = new Personas();
            int a;

            int.TryParse(IDNumericUpDown.Text, out a);
            persona.IdPersona = a;
            persona.IdTipoDePersona = (TipoDePersonaComboBox.SelectedIndex + 1);
            persona.Nombre = NombreTextBox.Text;
            persona.Apellido = ApellidoTextBox.Text;
            persona.Telefono = TelefonoTextBox.Text;
            persona.Email = EmailTextBox.Text;
            persona.Direccion = DireccionTextBox.Text;

            return persona;
        }

        private void edit(Personas p1)
        {
            p1.IdTipoDePersona = (TipoDePersonaComboBox.SelectedIndex + 1);
            p1.Nombre = NombreTextBox.Text;
            p1.Apellido = ApellidoTextBox.Text;
            p1.Telefono = TelefonoTextBox.Text;
            p1.Direccion = DireccionTextBox.Text;
            p1.Email = EmailTextBox.Text;
        }

        private void BuscarPersonaButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);
            Personas Persona = new Personas();
            TiposDePersonas tdp = new TiposDePersonas();

            Persona = PersonasBLL.Buscar(ID);

            if (Persona != null)
            {
                MessageBox.Show("Persona Encontrada");
                search(Persona);

                if (TiposDePersonasBLL.Buscar(Persona.IdTipoDePersona) != null)
                {
                    tdp = TiposDePersonasBLL.Buscar(Persona.IdTipoDePersona);
                    TipoDePersonaComboBox.Text = tdp.Tipo;
                }
            }
            else
            {
                MessageBox.Show("Persona No encontada");
            }
        }

        private void search(Personas p1)
        {
            TipoDePersonaComboBox.Text = (p1.IdTipoDePersona).ToString();
            NombreTextBox.Text = p1.Nombre;
            ApellidoTextBox.Text = p1.Apellido;
            TelefonoTextBox.Text = p1.Telefono;
            DireccionTextBox.Text = p1.Direccion;
            EmailTextBox.Text = p1.Email;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);

            if (PersonasBLL.Eliminar(ID))
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
            cPersonas cp = new cPersonas();
            cp.Show();
        }
    }
}
