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
            this.generosYLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dsBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new InformeRV.dsBD();
            this.generosYLibrosTableAdapter = new InformeRV.dsBDTableAdapters.generosYLibrosTableAdapter();
            this.btnFiltrarAutor = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBiblio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosYLibrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
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
            this.panel1.Controls.Add(this.btnFiltrarAutor);
            this.panel1.Controls.Add(this.txtAutor);
            this.panel1.Controls.Add(this.lblAutor);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.txtGenero);
            this.panel1.Controls.Add(this.lblGenero);
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
            // generosYLibrosBindingSource
            // 
            this.generosYLibrosBindingSource.DataMember = "generosYLibros";
            this.generosYLibrosBindingSource.DataSource = this.dsBDBindingSource;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(367, 14);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(86, 24);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Género:";
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(459, 14);
            this.txtGenero.Multiline = true;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(131, 24);
            this.txtGenero.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(473, 55);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(101, 38);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "FILTRAR:";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dsBDBindingSource
            // 
            this.dsBDBindingSource.DataSource = this.dsBD;
            this.dsBDBindingSource.Position = 0;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generosYLibrosTableAdapter
            // 
            this.generosYLibrosTableAdapter.ClearBeforeFill = true;
            // 
            // btnFiltrarAutor
            // 
            this.btnFiltrarAutor.BackColor = System.Drawing.Color.White;
            this.btnFiltrarAutor.FlatAppearance.BorderSize = 0;
            this.btnFiltrarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarAutor.Location = new System.Drawing.Point(737, 55);
            this.btnFiltrarAutor.Name = "btnFiltrarAutor";
            this.btnFiltrarAutor.Size = new System.Drawing.Size(101, 38);
            this.btnFiltrarAutor.TabIndex = 8;
            this.btnFiltrarAutor.Text = "FILTRAR:";
            this.btnFiltrarAutor.UseVisualStyleBackColor = false;
            this.btnFiltrarAutor.Click += new System.EventHandler(this.btnFiltrarAutor_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(723, 14);
            this.txtAutor.Multiline = true;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(131, 24);
            this.txtAutor.TabIndex = 7;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(631, 14);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(66, 24);
            this.lblAutor.TabIndex = 6;
            this.lblAutor.Text = "Autor:";
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
            ((System.ComponentModel.ISupportInitialize)(this.generosYLibrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
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
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnFiltrarAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
    }
}

