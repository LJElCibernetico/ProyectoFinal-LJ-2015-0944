﻿using ProyectoFinal_2015_0944.BLL;
using ProyectoFinal_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void buttonEntrar_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            List<Usuarios> user = new List<Usuarios>();

            filtrar = t => t.Username.Contains(userTextbox.Text);
            user = UsuariosBLL.GetList(filtrar);

            if (user.Exists(x => x.Username == userTextbox.Text) && user.Exists(x => x.Password == passwordTextbox.Text))
            {
                /*MainForm mf = new MainForm(this);
                mf.Show();
                this.Hide();*/
            }
            else
            {
               /*MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");*/
            }
        }
    }
}