using Proyecto.Vista.AgregarUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.IngresarUsuario
{
    internal class ControllerIngresarUsuario
    {
        frmAgregarUsuario ObjVista;

        public ControllerIngresarUsuario(frmAgregarUsuario vista)
        {
            ObjVista = vista;
        }

        void GuardarRegistro(object sender, EventArgs e)
        {
            //Verificar que los campos esten llenos
            if (!(string.IsNullOrEmpty(ObjVista.txt.Text.Trim()) || objVista.numCantidadLibros.Value == 0 || string.IsNullOrEmpty(objVista.txtISBN.Text.Trim())))
            {
                //Crear un objeto de tipo DAOBooks
                DAOBooks daoInsert = new DAOBooks();
                //Enviando valores de la vista hacia el DTO de libros
                daoInsert.NombreLibro = objVista.txtNombreLibro.Text.Trim();
                daoInsert.Stock = (int)objVista.numCantidadLibros.Value;
                daoInsert.ISBN1 = objVista.txtISBN.Text.Trim();
                if (objVista.checkDisponible.Checked == true ? daoInsert.Disponibilidad = true : daoInsert.Disponibilidad = false)
                    daoInsert.ProveedorId = (int)objVista.cmbProveedor.SelectedValue;
                daoInsert.AutorId = (int)objVista.cmbAutor.SelectedValue;
                daoInsert.AlmacenamientoId = (int)objVista.cmbAlmacenamiento.SelectedValue;
                int retorno = daoInsert.RegistrarLibros();
                if (retorno == 1)
                {
                    MessageBox.Show("El libro fue registrado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGridLibros();
                    LimpiarCampos();
                }
                else if (retorno == 0)
                {
                    MessageBox.Show("El libro no pudo ser registrado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos faltantes, complete el formulario con la información requerida", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
