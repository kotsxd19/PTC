using Proyecto.Modelo.DAO;
using Proyecto.Vista.Mascota;
using Proyecto.Vista.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Ventas
{
    internal class ControllerAgregarVenta
    {

        frmAgregarVentas objVentas;

        public ControllerAgregarVenta(frmAgregarVentas Vista)
        {
            objVentas = Vista;
            objVentas.Load += new EventHandler(CargaInicial); // Asocia el evento Load del formulario al método CargaInicial
            objVentas.btnIngresarVenta.Click += new EventHandler(NuevoRegistro); // Asocia el evento Click del botón Ingresar al método NuevoRegistro

        }


        public void CargaInicial(object sender, EventArgs e)
        {

            DAOVentas objAdmin = new DAOVentas(); // Crea una instancia del DAO para obtener datos
            DataSet ds = objAdmin.LLenarcomboProducto(); // Obtiene los datos para llenar el ComboBox de roles
            objVentas.cmbProductos.DataSource = ds.Tables["Producto"]; // Asocia el DataSource del ComboBox
            objVentas.cmbProductos.ValueMember = "IdProducto"; // Establece el valor que se utilizará
            objVentas.cmbProductos.DisplayMember = "Nombre"; // Establece el texto que se mostrará en el ComboBox

            DAOVentas objventa = new DAOVentas(); // Crea una instancia del DAO para obtener datos
            DataSet cb = objventa.LLenarcombocita(); // Obtiene los datos para llenar el ComboBox de roles
            objVentas.cmbCitas.DataSource = cb.Tables["Citas"]; // Asocia el DataSource del ComboBox
            objVentas.cmbCitas.ValueMember = "IdCitas"; // Establece el valor que se utilizará
            objVentas.cmbCitas.DisplayMember = "Descripcion"; // Establece el texto que se mostrará en el ComboBox


            objVentas.cmbEstado.Enabled = true;

            objVentas.cmbEstado.Items.Clear();

            objVentas.cmbEstado.Items.Add(new KeyValuePair<string, int>("Activo", 1));
            objVentas.cmbEstado.Items.Add(new KeyValuePair<string, int>("Inactivo", 2));

            objVentas.cmbEstado.DisplayMember = "Key";

            objVentas.cmbEstado.ValueMember = "Value";

            objVentas.cmbEstado.SelectedIndex = 0; // Esto selecciona "Activo" por defecto

            // Evita acceder al SelectedItem inmediatamente después de la carga
            objVentas.cmbEstado.SelectedIndexChanged += (s, ev) =>
            {
                if (objVentas.cmbEstado.SelectedItem != null)
                {
                    int estadoSeleccionado = ((KeyValuePair<String, int>)objVentas.cmbEstado.SelectedItem).Value;
                }
            };
        }

        public void NuevoRegistro(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(objVentas.cmbCitas.Text.Trim()) ||
                    string.IsNullOrEmpty(objVentas.cmbEstado.Text.Trim()) ||
                string.IsNullOrEmpty(objVentas.cmbProductos.Text.Trim())))
                {
                    DAOVentas DAOInsert = new DAOVentas();
                    DAOInsert.IdCitas1 = int.Parse(objVentas.cmbCitas.SelectedValue.ToString());
                    DAOInsert.IdProductos1 = int.Parse(objVentas.cmbProductos.SelectedValue.ToString());

                    int estadoSeleccionado = ((KeyValuePair<string, int>)objVentas.cmbEstado.SelectedItem).Value;
                    DAOInsert.EstadoVenta1 = estadoSeleccionado == 1;



                    int valorRetornado = DAOInsert.RegistarVentas(); // Registra el nuevo usuario
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
                else
                {
                    MessageBox.Show("Existen campos vacíos, complete cada uno de los apartados y verifique que la fecha seleccionada corresponde a una persona mayor de edad.",
                                        "Proceso interrumpido",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
