using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto.Vista.Propietario
{
    public partial class Propietario : Form
    {
        public Propietario()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbDUI_TextChanged(object sender, EventArgs e)
        {

        }

        string conexion = "Data Source=SQL8020.site4now.net;Persist Security Info=True;User ID=db_aad183_vetmanager_admin;Encrypt=False";

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))

            {
                SqlCommand cmd = new SqlCommand("Insert  into Propietario (IDCliente,Nombre, Apellido,Telefono)values( "+ txtbDUI.Text + ",'"+ txtbNombre.Text + "','" + txtbApellido.Text + "','" + txtbTelefono.Text + ",')",cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();

            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))

            {
                SqlCommand cmd = new SqlCommand("update Propietario set  Nombre = '"+ txtbNombre.Text + "' , Apellido = '" + txtbApellido.Text + "', Telefono = '" + txtbTelefono.Text + "' where IdCliente = "+ txtbDUI.Text + "", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Propietario", cn);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;

                cn.Open();

                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            

        }

        private void btmdelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))

            {
                SqlCommand cmd = new SqlCommand("Delete from Propietario where IdCliente = " + txtbDUI.Text , cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
