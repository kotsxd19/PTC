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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
            ControllerRegistroProductos producto = new ControllerRegistroProductos(this);
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
