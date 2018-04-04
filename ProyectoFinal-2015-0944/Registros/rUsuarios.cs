using ProyectoFinal_2015_0944.BLL;
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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
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
            UserNameTextBox.Text = String.Empty;
            PasswordTextBox.Text = String.Empty;
            ConfirmacionTextBox.Text = String.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
            NombreTextBox.Text = String.Empty;
            ComentarioTextBox.Text = String.Empty;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(IDNumericUpDown.Text, out ID);
            Usuarios usuario = UsuariosBLL.Buscar(ID);

            if (usuario == null)
            {
                Usuarios u = LlenarClase();
                if (NombreTextBox.Text == String.Empty || UserNameTextBox.Text == String.Empty
                   || PasswordTextBox.Text == String.Empty || ConfirmacionTextBox.Text == String.Empty
                   || FechaDateTimePicker.Text == String.Empty || NombreTextBox.Text == String.Empty 
                   || ComentarioTextBox.Text == String.Empty)
                    errorProvider1.SetError(GuardarButton, "No puede dejar nada vacio");
                else if(PasswordTextBox.Text == ConfirmacionTextBox.Text)
                {
                    if (UsuariosBLL.Guardar(u))
                        MessageBox.Show("Usuario Guardado");
                    else if (!UsuariosBLL.Guardar(u))
                        MessageBox.Show("Este Usuario No Pudo Ser Guardado");
                    ClearAll();
                }
                else if(PasswordTextBox.Text != ConfirmacionTextBox.Text)
                {
                    MessageBox.Show("La contraseña y la confirmacion no son iguales");
                }
            }
            else
            {
                edit(usuario);
                if (UsuariosBLL.Modificar(usuario))
                    MessageBox.Show("Acaba de Modificar Este Usuario");
                else
                    MessageBox.Show("No Se Pudo Modificar Este Usuario");
                ClearAll();
            }
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();
            int a;
            int.TryParse(IDNumericUpDown.Text, out a);
            usuario.IdUsuario = a;
            usuario.Nombre = NombreTextBox.Text;
            usuario.Username = UserNameTextBox.Text;
            usuario.Password = PasswordTextBox.Text;
            usuario.Fecha = FechaDateTimePicker.Value;
            usuario.Comentario = ComentarioTextBox.Text;

            return usuario;
        }

        private void edit(Usuarios usuario)
        {
            usuario.Nombre = NombreTextBox.Text;
            usuario.Username = UserNameTextBox.Text;
            usuario.Password = PasswordTextBox.Text;
            usuario.Fecha = FechaDateTimePicker.Value;
            usuario.Comentario = ComentarioTextBox.Text;
        }

        private void BuscarPersonaButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);
            Usuarios usuario = new Usuarios();

            usuario = UsuariosBLL.Buscar(ID);

            if (usuario != null)
            {
                MessageBox.Show("Usuario Encontrado");
                search(usuario);
            }
            else
            {
                MessageBox.Show("Usuario No encontado");
            }
        }

        private void search(Usuarios usuario)
        {
            NombreTextBox.Text = usuario.Nombre;
            UserNameTextBox.Text = usuario.Username;
            PasswordTextBox.Text = usuario.Password;
            FechaDateTimePicker.Value = usuario.Fecha;
            ComentarioTextBox.Text = usuario.Comentario;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(IDNumericUpDown.Text);

            if (UsuariosBLL.Eliminar(ID))
            {
                MessageBox.Show("Usuario Eliminado");
            }
            else
            {
                errorProvider1.SetError(EliminarButton, "No se puede eliminar un Usuario que no existe");
            }
            ClearAll();
        }
    }
}
