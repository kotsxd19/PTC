using Proyecto.Controlador.IngresarUsuario;
using Proyecto.Controlador.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.Producto
{
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto(int accion)
        {
            InitializeComponent();
            ControllerIngresoProductos objAgregarUser = new ControllerIngresoProductos(this, accion);
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
