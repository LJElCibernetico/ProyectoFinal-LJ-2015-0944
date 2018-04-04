namespace ProyectoFinal_2015_0944.Reportes
{
    partial class ImprimirProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirProductos));
            this.ProductosCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ProductosCrystalReportViewer
            // 
            this.ProductosCrystalReportViewer.ActiveViewIndex = -1;
            this.ProductosCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductosCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductosCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductosCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ProductosCrystalReportViewer.Name = "ProductosCrystalReportViewer";
            this.ProductosCrystalReportViewer.Size = new System.Drawing.Size(347, 409);
            this.ProductosCrystalReportViewer.TabIndex = 0;
            this.ProductosCrystalReportViewer.Load += new System.EventHandler(this.ProductosCrystalReportViewer_Load);
            // 
            // ImprimirProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 409);
            this.Controls.Add(this.ProductosCrystalReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImprimirProductos";
            this.Text = "Imprimir Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ProductosCrystalReportViewer;
    }
}