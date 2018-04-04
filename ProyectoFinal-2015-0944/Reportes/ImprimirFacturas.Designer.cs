namespace ProyectoFinal_2015_0944.Reportes
{
    partial class ImprimirFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirFacturas));
            this.FacturasCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FacturasCrystalReportViewer
            // 
            this.FacturasCrystalReportViewer.ActiveViewIndex = -1;
            this.FacturasCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacturasCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.FacturasCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacturasCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.FacturasCrystalReportViewer.Name = "FacturasCrystalReportViewer";
            this.FacturasCrystalReportViewer.Size = new System.Drawing.Size(481, 487);
            this.FacturasCrystalReportViewer.TabIndex = 0;
            this.FacturasCrystalReportViewer.Load += new System.EventHandler(this.FacturasCrystalReportViewer_Load);
            // 
            // ImprimirFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 487);
            this.Controls.Add(this.FacturasCrystalReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImprimirFacturas";
            this.Text = "Imprimir Facturas";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer FacturasCrystalReportViewer;
    }
}