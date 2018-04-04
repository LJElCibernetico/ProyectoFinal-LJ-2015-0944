using ProyectoFinal_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_2015_0944.Reportes
{
    public partial class ImprimirPersonas : Form
    {
        List<Personas> datos = new List<Personas>();
        public ImprimirPersonas(List<Personas> data)
        {
            InitializeComponent();
            datos = data;
        }

        private void PersonasCrystalReportViewer_Load(object sender, EventArgs e)
        {
            PersonasCrystalReport r = new PersonasCrystalReport();

            r.Load(@"C:\Users\LJ\Desktop\Programacion\7. Aplicada 1\Proyecto Final\ProyectoFinal-2015-0944\ProyectoFinal-2015-0944\Reportes\PersonasCrystalReport.rpt");
            r.SetDataSource(datos);

            PersonasCrystalReportViewer.ReportSource = r;
            PersonasCrystalReportViewer.Refresh();
        }
    }
}
