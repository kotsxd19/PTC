using Proyecto.Controlador.Citas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.InterfazCitas
{
    public partial class frmCitas : Form

    {
        public frmCitas()
        {
            InitializeComponent();

            ControllerCitas controller = new ControllerCitas(this);
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void MenuCitas_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnIngresarCita_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvInfoCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImprimirCitas(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvCitas.Width, this.dgvCitas.Height);
            dgvCitas.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvCitas.Width, this.dgvCitas.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
