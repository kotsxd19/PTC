using Proyecto.Controlador.Ventas;
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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            ControllerRegistroVenta registroventa = new ControllerRegistroVenta(this);
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
