using ProyectoFinal_2015_0944.BLL;
using ProyectoFinal_2015_0944.Entidades;
using ProyectoFinal_2015_0944.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_2015_0944
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            List<Usuarios> user = new List<Usuarios>();

            filtrar = t => t.Username.Contains(UsernameTextBox.Text);
            user = UsuariosBLL.GetList(filtrar);

            if (user.Exists(x => x.Username == UsernameTextBox.Text) && user.Exists(x => x.Password == PasswordTextBox.Text))
            {
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
            }
        }
    }
}
