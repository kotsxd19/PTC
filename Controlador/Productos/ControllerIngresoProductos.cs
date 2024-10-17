using Proyecto.Modelo.DAO;
using Proyecto.Vista.Producto;
using Proyecto.Vista.Proveedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Productos
{
    internal class ControllerIngresoProductos
    {
        frmAgregarProducto ObjAgregar;
        private int accion;
        private string Proveedor;

        public ControllerIngresoProductos(frmAgregarProducto objAgregar, int accion)
        {
            ObjAgregar = objAgregar;
            this.accion = accion;

            verificarAccion(); // Verifica la acción para habilitar o deshabilitar controles según la acción
            ObjAgregar.btnIngresarProducto.Click += new EventHandler(NuevoRegistro); // Asocia el evento Click del botón Ingresar al método NuevoRegistro
            ObjAgregar.Load += new EventHandler(CargaInicial);
        }

        public void verificarAccion()
        {
            if (accion == 1) // Acción de agregar nuevo usuario
            {
                ObjAgregar.btnIngresarProducto.Enabled = true;
                ObjAgregar.btnActualizarProducto.Enabled = false;
                ObjAgregar.btnCancelar.Enabled = true;
            }
            else if (accion == 2) // Acción de editar usuario
            {
                ObjAgregar.btnIngresarProducto.Enabled = false;
                ObjAgregar.btnActualizarProducto.Enabled = true;
            }
        }

        public void CargaInicial(object sender, EventArgs e)
        {
            DAOProducto objAdmin = new DAOProducto(); // Crea una instancia del DAO para obtener datos
            DataSet ds = objAdmin.LlenarComboBox(); // Obtiene los datos para llenar el ComboBox de roles
            ObjAgregar.cmbProveedor.DataSource = ds.Tables["Proveedor"]; // Asocia el DataSource del ComboBox
            ObjAgregar.cmbProveedor.ValueMember = "IdProveedor"; // Establece el valor que se utilizará
            ObjAgregar.cmbProveedor.DisplayMember = "Nombre"; // Establece el texto que se mostrará en el ComboBox

            if (accion == 2)
            {
                ObjAgregar.cmbProveedor.Text = Proveedor; // Establece el texto del ComboBox para la acción de edición
            }

            ObjAgregar.cmbEstado.Enabled = true;

            ObjAgregar.cmbEstado.Items.Clear();

            ObjAgregar.cmbEstado.Items.Add(new KeyValuePair<string, int>("Activo", 1));
            ObjAgregar.cmbEstado.Items.Add(new KeyValuePair<string, int>("Inactivo", 2));

            ObjAgregar.cmbEstado.DisplayMember = "Key";

            ObjAgregar.cmbEstado.ValueMember = "Value";

            ObjAgregar.cmbEstado.SelectedIndex = 0; // Esto selecciona "Activo" por defecto

            // Evita acceder al SelectedItem inmediatamente después de la carga
            ObjAgregar.cmbEstado.SelectedIndexChanged += (s, ev) =>
            {
                if (ObjAgregar.cmbEstado.SelectedItem != null)
                {
                    int estadoSeleccionado = ((KeyValuePair<String, int>)ObjAgregar.cmbEstado.SelectedItem).Value;
                }
            };
        }

            public void NuevoRegistro(object sender, EventArgs e)
        {
            try
            {
                    DAOProducto DAOInsert = new DAOProducto();
                    DAOInsert.Nombre1 = ObjAgregar.txtNombreProducto.Text;
                    DAOInsert.CodigoDeBarra1 = ObjAgregar.txtCodigoDeBarra.Text;
                    DAOInsert.Precio1 = decimal.Parse(ObjAgregar.txtPrecio.Text);
                    DAOInsert.IdProveedor1 = (int)(ObjAgregar.cmbProveedor.SelectedValue);
                    int estadoSeleccionado = ((KeyValuePair<string, int>)ObjAgregar.cmbEstado.SelectedItem).Value;
                    DAOInsert.EstadoProducto1 = estadoSeleccionado == 1;

                    int valorRetornado = DAOInsert.RegistarProducto(); // Registra el nuevo usuario
                    if (valorRetornado == 1)
                    {
                        MessageBox.Show("Los datos ingresados han sido registrados exitosamente",
                                        "Proceso completado",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Los datos que ingreso no pudieron ser registrados correctamente",
                                        "Proceso interrumpido",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
