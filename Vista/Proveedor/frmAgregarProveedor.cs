using Proyecto.Controlador.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.Proveedor
{
    public partial class frmAgregarProveedor : Form
    {
        public frmAgregarProveedor(int accion)
        {
            InitializeComponent();
            ControllerAgregarProveedor ObjAgregar = new ControllerAgregarProveedor(this, accion);
        }

        private void frmAgregarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
