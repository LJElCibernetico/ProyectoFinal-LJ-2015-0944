﻿using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Aplicada2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSingIn_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            List<Usuarios> user = new List<Usuarios>();
            RepositorioBase<Usuarios> usuario = new RepositorioBase<Usuarios>();

            filtrar = t => t.Username.Contains(TextBoxUsername.Text);
            user = usuario.GetList(filtrar);

            if (user.Exists(x => x.Username == TextBoxUsername.Text) && user.Exists(x => x.Password == TextBoxPassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBoxUsername.Text, true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Username Or Password Incorrect');", addScriptTags: true);
            }

            /*Expression<Func<Usuarios, bool>> filtrar = x => true;
            Usuarios user = new Usuarios();

            filtrar = t => t.Username.Equals(TextBoxUsername.Text) && t.Password.Equals(TextBoxPassword.Text);
            if (usuario.GetList(filtrar).Count() != 0)
                FormsAuthentication.RedirectFromLoginPage(user.Username, true);
            else
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Username Or Password Incorrect');", addScriptTags: true);*/
        }
    }
}