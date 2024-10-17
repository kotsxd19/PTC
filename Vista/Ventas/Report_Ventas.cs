using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.Ventas
{
    public partial class Report_Ventas : Form
    {
        public Report_Ventas()
        {
            InitializeComponent();
        }

        private void Report_Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_ReportGeneralVentas.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.ObtenerVentas(this.dataSet_ReportGeneralVentas.Ventas);

            this.reportViewer1.RefreshReport();
        }
    }
}
