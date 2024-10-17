using Proyecto.Modelo.DAO;
using Proyecto.Vista.Mascota;
using Proyecto.Vista.Proveedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Mascota
{
    internal class ControllerAgregarMascota
    {
        frmAgregarMascota objMascota;

        public ControllerAgregarMascota(frmAgregarMascota Vista)
        {
            objMascota = Vista;
            objMascota.Load += new EventHandler(CargaInicial); // Asocia el evento Load del formulario al método CargaInicial
            objMascota.btnIngresarMascotas.Click += new EventHandler(NuevoRegistro); // Asocia el evento Click del botón Ingresar al método NuevoRegistro

        }


        public void CargaInicial(object sender, EventArgs e)
        {

            DAOMascotas objAdmin = new DAOMascotas(); // Crea una instancia del DAO para obtener datos
            DataSet ds = objAdmin.LlenarComboBox(); // Obtiene los datos para llenar el ComboBox de roles
            objMascota.cmbDueños.DataSource = ds.Tables["Propietario"]; // Asocia el DataSource del ComboBox
            objMascota.cmbDueños.ValueMember = "IdCliente"; // Establece el valor que se utilizará
            objMascota.cmbDueños.DisplayMember = "Nombre"; // Establece el texto que se mostrará en el ComboBox

            DAOMascotas objcliente = new DAOMascotas(); // Crea una instancia del DAO para obtener datos
            DataSet cb = objAdmin.LlenarComboBox2(); // Obtiene los datos para llenar el ComboBox de roles
            objMascota.cmbGenero.DataSource = cb.Tables["Genero"]; // Asocia el DataSource del ComboBox
            objMascota.cmbGenero.ValueMember = "IdGenero"; // Establece el valor que se utilizará
            objMascota.cmbGenero.DisplayMember = "Genero"; // Establece el texto que se mostrará en el ComboBox


            objMascota.cmbEstado.Enabled = true;

            objMascota.cmbEstado.Items.Clear();

            objMascota.cmbEstado.Items.Add(new KeyValuePair<string, int>("Activo", 1));
            objMascota.cmbEstado.Items.Add(new KeyValuePair<string, int>("Inactivo", 2));

            objMascota.cmbEstado.DisplayMember = "Key";

            objMascota.cmbEstado.ValueMember = "Value";

            objMascota.cmbEstado.SelectedIndex = 0; // Esto selecciona "Activo" por defecto

            // Evita acceder al SelectedItem inmediatamente después de la carga
            objMascota.cmbEstado.SelectedIndexChanged += (s, ev) =>
            {
                if (objMascota.cmbEstado.SelectedItem != null)
                {
                    int estadoSeleccionado = ((KeyValuePair<String, int>)objMascota.cmbEstado.SelectedItem).Value;
                }
            };
        }

        public void NuevoRegistro(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(objMascota.txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(objMascota.txtpeso.Text.Trim()) ||
                string.IsNullOrEmpty(objMascota.cmbEstado.Text.Trim()) ||
                string.IsNullOrEmpty(objMascota.txtraza.Text.Trim()) ||
                string.IsNullOrEmpty(objMascota.cmbGenero.Text.Trim()) ||
                string.IsNullOrEmpty(objMascota.cmbDueños.Text.Trim())))
                {
                    DAOMascotas DAOInsert = new DAOMascotas();
                    DAOInsert.Nombre = objMascota.txtNombre.Text.Trim();
                    DAOInsert.Peso = decimal.Parse(objMascota.txtpeso.Text.Trim());
                    DAOInsert.Raza = objMascota.txtraza.Text.Trim();
                    DAOInsert.Genero = int.Parse(objMascota.cmbGenero.SelectedValue.ToString());
                    DAOInsert.Idcliente = int.Parse(objMascota.cmbDueños.SelectedValue.ToString());

                    int estadoSeleccionado = ((KeyValuePair<string, int>)objMascota.cmbEstado.SelectedItem).Value;
                    DAOInsert.EstadoMascota = estadoSeleccionado == 1;



                    int valorRetornado = DAOInsert.RegistarMascotas(); // Registra el nuevo usuario
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
