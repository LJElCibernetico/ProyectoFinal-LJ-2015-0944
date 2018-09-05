using ProyectoFinal_2015_0944.BLL;
using ProyectoFinal_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Web.pages.Consultas
{
    public partial class cDepartamentos : System.Web.UI.Page
    {
        Expression<Func<Departamentos, bool>> filtrar = x => true;

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            DataRow dr = null;

            dt.Columns.Add(new DataColumn("IdDepartamento", typeof(string)));
            dt.Columns.Add(new DataColumn("Departamento", typeof(string)));

            dr = dt.NewRow();
            dt.Rows.Add(dr);

            GridView.DataSource = dt;
            GridView.DataBind();
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            int id;
            if (FiltroTextBox.Text.Equals("ID"))
            {
                id = int.Parse(CriterioTextBox.Text);
                filtrar = t => t.IdDepartamento == id;
            }
            else if (FiltroTextBox.Text.Equals("Descripcion"))
                filtrar = t => t.Departamento.Contains(CriterioTextBox.Text);

            GridView.DataSource = DepartamentosBLL.GetList(filtrar);
            GridView.DataBind();
        }
    }
}