namespace Proyecto.Vista.citas
{
    partial class Report_Citas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtBuscadorProveedor = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_ReportGeneralCitas = new Proyecto.Vista.citas.DataSet_ReportGeneralCitas();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasTableAdapter = new Proyecto.Vista.citas.DataSet_ReportGeneralCitasTableAdapters.CitasTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportGeneralCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnBuscarProveedor);
            this.panel4.Controls.Add(this.txtBuscadorProveedor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1148, 69);
            this.panel4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar empleado:";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Image = global::Proyecto.Properties.Resources.icons8_buscar_30;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(541, 18);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(47, 36);
            this.btnBuscarProveedor.TabIndex = 1;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorProveedor
            // 
            this.txtBuscadorProveedor.Location = new System.Drawing.Point(144, 25);
            this.txtBuscadorProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscadorProveedor.Name = "txtBuscadorProveedor";
            this.txtBuscadorProveedor.Size = new System.Drawing.Size(388, 22);
            this.txtBuscadorProveedor.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.citasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.Vista.citas.Report_GeneralCitas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1148, 502);
            this.reportViewer1.TabIndex = 11;
            // 
            // dataSet_ReportGeneralCitas
            // 
            this.dataSet_ReportGeneralCitas.DataSetName = "DataSet_ReportGeneralCitas";
            this.dataSet_ReportGeneralCitas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.dataSet_ReportGeneralCitas;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // Report_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 571);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel4);
            this.Name = "Report_Citas";
            this.Text = "Report_Citas";
            this.Load += new System.EventHandler(this.Report_Citas_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ReportGeneralCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscarProveedor;
        public System.Windows.Forms.TextBox txtBuscadorProveedor;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_ReportGeneralCitas dataSet_ReportGeneralCitas;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private DataSet_ReportGeneralCitasTableAdapters.CitasTableAdapter citasTableAdapter;
    }
}