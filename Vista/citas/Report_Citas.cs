using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.citas
{
    public partial class Report_Citas : Form
    {
        public Report_Citas()
        {
            InitializeComponent();
        }

        private void Report_Citas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_ReportGeneralCitas.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.ObtenerCitas(this.dataSet_ReportGeneralCitas.Citas);

            this.reportViewer1.RefreshReport();
        }
    }
}
