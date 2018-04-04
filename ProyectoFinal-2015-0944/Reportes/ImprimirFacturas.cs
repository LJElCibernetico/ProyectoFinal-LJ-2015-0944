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
    public partial class ImprimirFacturas : Form
    {
        List<Facturas> datos = new List<Facturas>();
        public ImprimirFacturas(List<Facturas> data)
        {
            InitializeComponent();
            datos = data;
        }

        private void FacturasCrystalReportViewer_Load(object sender, EventArgs e)
        {
            FacturasCrystalReport r = new FacturasCrystalReport();

            r.Load(@"C:\Users\LJ\Desktop\Programacion\7. Aplicada 1\Proyecto Final\ProyectoFinal-2015-0944\ProyectoFinal-2015-0944\Reportes\FacturasCrystalReport.rpt");
            r.SetDataSource(datos);

            FacturasCrystalReportViewer.ReportSource = r;
            FacturasCrystalReportViewer.Refresh();
        }
    }
}
