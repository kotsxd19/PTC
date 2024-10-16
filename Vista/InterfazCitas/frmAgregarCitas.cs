using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Controlador;
using Proyecto.Controlador.Citas;
namespace Proyecto.Vista.InterfazCitas
{
    public partial class frmAgregarCitas : Form
    {
        public frmAgregarCitas()
        {
            InitializeComponent();
            ControllerAgregarCitas control = new ControllerAgregarCitas(this);
        }

        public frmAgregarCitas(int IdCitas, int IdEmpleados, int IdMascota, DateTime Fecha, TimeSpan Hora, string Descripcion)
        {
            InitializeComponent();
            ControllerAgregarCitas control = new ControllerAgregarCitas(this, IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        }

        private void frmAgregarCitas_Load(object sender, EventArgs e)
        {

        }
    }
}
