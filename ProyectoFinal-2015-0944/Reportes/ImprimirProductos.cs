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
    public partial class ImprimirProductos : Form
    {
        List<Productos> datos = new List<Productos>();
        public ImprimirProductos(List<Productos> data)
        {
            InitializeComponent();
            datos = data;
        }

        private void ProductosCrystalReportViewer_Load(object sender, EventArgs e)
        {
            ProductosCrystalReport r = new ProductosCrystalReport();

            r.Load(@"C:\Users\LJ\Desktop\Programacion\7. Aplicada 1\Proyecto Final\ProyectoFinal-2015-0944\ProyectoFinal-2015-0944\Reportes\ProductosCrystalReport.rpt");
            r.SetDataSource(datos);

            ProductosCrystalReportViewer.ReportSource = r;
            ProductosCrystalReportViewer.Refresh();
        }
    }
}
