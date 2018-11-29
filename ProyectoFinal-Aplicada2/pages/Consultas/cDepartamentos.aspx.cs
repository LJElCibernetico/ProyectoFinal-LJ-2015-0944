using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Aplicada2.pages.Consultas
{
    public partial class cDepartamentos : System.Web.UI.Page
    {
        Expression<Func<Departamentos, bool>> filter = x => true;

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Departamentos> u = new List<Departamentos>();
            u.Add(new Departamentos());
            DepartamentoGridView.DataSource = u;
            DepartamentoGridView.DataBind();
        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            switch (DropDownListFiltro.SelectedIndex)
            {
                case 0://Todo
                    filter = x => true;
                    break;

                case 1://UsuarioId
                    id = int.Parse(TextBoxBuscar.Text);
                    filter = (x => x.IdDepartamento == id);
                    break;

                case 2://Nombre Usuario
                    filter = (x => x.Departamento.Contains(TextBoxBuscar.Text));
                    break;
            }

            RepositorioBase<Departamentos> rep = new RepositorioBase<Departamentos>();
            DepartamentoGridView.DataSource = rep.GetList(filter);
            DepartamentoGridView.DataBind();
        }
    }
}