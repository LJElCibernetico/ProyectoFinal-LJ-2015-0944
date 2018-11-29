﻿using BLL;
using Entidades;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Aplicada2.pages.Consultas
{
    public partial class cUsuarios : System.Web.UI.Page
    {
        Expression<Func<Usuarios, bool>> filter = x => true;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                /*UsuarioReportViewer.ProcessingMode = ProcessingMode.Local;
                UsuarioReportViewer.LocalReport.ReportPath = Server.MapPath(@"~\Report\UsuarioReport.rdlc");
                UsuarioReportViewer.AsyncRendering = true;*/

                TextBoxFechaInicial.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
                TextBoxFechaFinal.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");

                UsuariosReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
                UsuariosReportViewer.Reset();
                UsuariosReportViewer.LocalReport.DataSources.Clear();
                UsuariosReportViewer.LocalReport.ReportPath = Server.MapPath(@"~\Reportes\ReportUsuarios.rdlc");
                
                    TextBoxBuscar.TextMode.Equals(TextBoxMode.Number);
            }
        }

        protected void DatosGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            RepositorioBase<Usuarios> rep = new RepositorioBase<Usuarios>();
            UsuarioGridView.DataSource = rep.GetList(filter);
            UsuarioGridView.PageIndex = e.NewPageIndex;
            UsuarioGridView.DataBind();
        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            string i = DateTime.Parse(TextBoxFechaInicial.Text).Date.ToString("yyyy-MM-dd");
            DateTime fInicial = DateTime.Parse(i);

            string f = DateTime.Parse(TextBoxFechaFinal.Text).Date.ToString("yyyy-MM-dd");
            DateTime fFinal = DateTime.Parse(f);

            int id = 0;
            switch (DropDownListFiltro.SelectedIndex)
            {
                case 0://Todo
                    filter = x => true;
                    break;

                case 1://UsuarioId
                    id = int.Parse(TextBoxBuscar.Text);
                    filter = (x => x.IdUsuario == id);
                    break;

                case 2://Nombre Usuario
                    filter = (x => x.Username.Contains(TextBoxBuscar.Text) && ((x.Fecha >= fInicial) && (x.Fecha <= fFinal)));
                    break;

                case 3://Password
                    filter = (x => x.Password.Contains(TextBoxBuscar.Text) && ((x.Fecha >= fInicial) && (x.Fecha <= fFinal)));
                    break;
            }

            RepositorioBase<Usuarios> rep = new RepositorioBase<Usuarios>();
            UsuarioGridView.DataSource = rep.GetList(filter);
            UsuarioGridView.DataBind();
        }

        RepositorioBase<Usuarios> usuario = new RepositorioBase<Usuarios>();

        protected void ButtonImprimir_Click(object sender, EventArgs e)
        {
            UsuariosReportViewer.LocalReport.DataSources.Clear();
            UsuariosReportViewer.LocalReport.DataSources.Add(new ReportDataSource("UsuariosDataSet",  usuario.GetList(filter)));
            UsuariosReportViewer.LocalReport.Refresh();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ReporteModal", "$('#ReporteModal').modal();", true);
        }
    }
}