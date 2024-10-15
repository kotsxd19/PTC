using Proyecto.Controlador.Mascota;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.Mascota
{
    public partial class frmMascota : Form
    {
        public frmMascota()
        {
            InitializeComponent();
            ControllerMascota Mascota = new ControllerMascota(this);
        }

        private void frmMascota_Load(object sender, EventArgs e)
        {

        }
    }
}
