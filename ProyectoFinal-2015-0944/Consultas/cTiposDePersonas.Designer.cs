namespace ProyectoFinal_2015_0944.Consultas
{
    partial class cTiposDePersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cTiposDePersonas));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.TiposDePersonasDataGridView = new System.Windows.Forms.DataGridView();
            this.FechaFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaInicialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TiposDePersonasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Metodo de busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = " Filtro";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(107, 106);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(349, 20);
            this.CriterioTextBox.TabIndex = 43;
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Items.AddRange(new object[] {
            "ID",
            "Departamento"});
            this.FiltrarComboBox.Location = new System.Drawing.Point(11, 105);
            this.FiltrarComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(92, 21);
            this.FiltrarComboBox.TabIndex = 42;
            // 
            // TiposDePersonasDataGridView
            // 
            this.TiposDePersonasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TiposDePersonasDataGridView.Location = new System.Drawing.Point(11, 130);
            this.TiposDePersonasDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.TiposDePersonasDataGridView.Name = "TiposDePersonasDataGridView";
            this.TiposDePersonasDataGridView.RowTemplate.Height = 24;
            this.TiposDePersonasDataGridView.Size = new System.Drawing.Size(522, 298);
            this.TiposDePersonasDataGridView.TabIndex = 41;
            // 
            // FechaFinalDateTimePicker
            // 
            this.FechaFinalDateTimePicker.Location = new System.Drawing.Point(282, 35);
            this.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker";
            this.FechaFinalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaFinalDateTimePicker.TabIndex = 49;
            // 
            // FechaInicialDateTimePicker
            // 
            this.FechaInicialDateTimePicker.Location = new System.Drawing.Point(64, 35);
            this.FechaInicialDateTimePicker.Name = "FechaInicialDateTimePicker";
            this.FechaInicialDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.FechaInicialDateTimePicker.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Fecha Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha Final";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ProyectoFinal_2015_0944.Properties.Resources.preview_search_find_locate_1551;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BuscarButton.Location = new System.Drawing.Point(461, 86);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(72, 40);
            this.BuscarButton.TabIndex = 46;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // cTiposDePersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaFinalDateTimePicker);
            this.Controls.Add(this.FechaInicialDateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltrarComboBox);
            this.Controls.Add(this.TiposDePersonasDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cTiposDePersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Tipos de Personas";
            ((System.ComponentModel.ISupportInitialize)(this.TiposDePersonasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.DataGridView TiposDePersonasDataGridView;
        private System.Windows.Forms.DateTimePicker FechaFinalDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaInicialDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}