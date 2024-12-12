namespace InformeRV
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pbLogoBiblio = new System.Windows.Forms.PictureBox();
            this.dsBD = new InformeRV.dsBD();
            this.dsBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generosYLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generosYLibrosTableAdapter = new InformeRV.dsBDTableAdapters.generosYLibrosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBiblio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosYLibrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetGenerosYLibros";
            reportDataSource1.Value = this.generosYLibrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InformeRV.Informe1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(906, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.pbLogoBiblio);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 103);
            this.panel1.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(139, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(101, 24);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "fecha hoy";
            // 
            // pbLogoBiblio
            // 
            this.pbLogoBiblio.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoBiblio.Image")));
            this.pbLogoBiblio.Location = new System.Drawing.Point(34, 14);
            this.pbLogoBiblio.Name = "pbLogoBiblio";
            this.pbLogoBiblio.Size = new System.Drawing.Size(83, 79);
            this.pbLogoBiblio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoBiblio.TabIndex = 1;
            this.pbLogoBiblio.TabStop = false;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBDBindingSource
            // 
            this.dsBDBindingSource.DataSource = this.dsBD;
            this.dsBDBindingSource.Position = 0;
            // 
            // generosYLibrosBindingSource
            // 
            this.generosYLibrosBindingSource.DataMember = "generosYLibros";
            this.generosYLibrosBindingSource.DataSource = this.dsBDBindingSource;
            // 
            // generosYLibrosTableAdapter
            // 
            this.generosYLibrosTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBiblio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosYLibrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogoBiblio;
        private System.Windows.Forms.Label lblFecha;
        private dsBD dsBD;
        private System.Windows.Forms.BindingSource dsBDBindingSource;
        private System.Windows.Forms.BindingSource generosYLibrosBindingSource;
        private dsBDTableAdapters.generosYLibrosTableAdapter generosYLibrosTableAdapter;
    }
}

