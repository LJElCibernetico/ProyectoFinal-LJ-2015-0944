using ProyectoFinal_2015_0944.Consultas;
using ProyectoFinal_2015_0944.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_2015_0944.Menu
{
    public partial class MainForm : Form
    {
        Login lo;
        public MainForm(Login l)
        {
            lo = l;
            InitializeComponent();
            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPersonas rp = new rPersonas();
            rp.MdiParent = this;
            rp.Show();
        }

        private void tipoDePersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTiposDePersonas rtdp = new rTiposDePersonas();
            rtdp.MdiParent = this;
            rtdp.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPersonas rp = new rPersonas();
            rp.MdiParent = this;
            rp.Show();
        }

        private void tipoDePersonaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rTiposDePersonas rtdp = new rTiposDePersonas();
            rtdp.MdiParent = this;
            rtdp.Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cPersonas cp = new cPersonas();
            cp.MdiParent = this;
            cp.Show();
        }

        private void tipoDePersonaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cTiposDePersonas ctdp = new cTiposDePersonas();
            ctdp.MdiParent = this;
            ctdp.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void departamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rDepartamentos rd = new rDepartamentos();
            rd.MdiParent = this;
            rd.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cDepartamentos cd = new cDepartamentos();
            cd.MdiParent = this;
            cd.Show();
        }

        private void productoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rProductos rp = new rProductos();
            rp.MdiParent = this;
            rp.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProductos cp = new cProductos();
            cp.MdiParent = this;
            cp.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lo.Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios ru = new rUsuarios();
            ru.MdiParent = this;
            ru.Show();
        }

        private void facturaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rFacturas rp = new rFacturas();
            rp.MdiParent = this;
            rp.Show();
        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cFacturas cp = new cFacturas();
            cp.MdiParent = this;
            cp.Show();
        }
    }
}
