using Proyecto.Modelo.DAO;
using Proyecto.Modelo.DTO;
using Proyecto.Vista.citas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.cita
{
    internal class ControllerAgregarCita
    {
        frmcitas objCitas;


        public ControllerAgregarCita(frmcitas vista)
        {
            objCitas = vista;
            objCitas.Load += new EventHandler(iniciar);
            objCitas.btnIngresar.Click += new EventHandler(AgregarCitas);
        }

        //public ControllerAgregarCita(frmcitas vista, int IdCitas, int IdEmpleados, int IdMascota, DateTime Fecha, TimeSpan Hora, string Descripcion)
        //{
        //    objCitas = vista;
        //    objCitas.Load += new EventHandler(iniciar);
        //    objCitas.btnIngresar.Click += new EventHandler(AgregarCitas);
        //    objCitas.btnActualizar.Click += new EventHandler(ActualizarCitas);
        //}

        //void CargarDatosActualizar()
        //{
        //    CargarDatos(IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        //}

        //public void CargarDatos(int IdCitas, int IdEmpleados, int IdMascota, DateTime Fecha, TimeSpan Hora, string Descripcion)
        //{
        //    objCitas.cmbEmpleado.SelectedValue = IdEmpleados;
        //    objCitas.txtDescripcion.Text = Descripcion;
        //    CargarDatos(IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        //}

        //private void ActualizarCitas(object sender, EventArgs e)
        //{

        //}

        private void iniciar(object sender, EventArgs e)
        {
            LLenarcombos();
        }



        void LLenarcombos()
        {

            DAOCitas daoCitas = new DAOCitas();
            DataSet ds = daoCitas.LLenarcomboEmpleados();
            objCitas.cmbEmpleado.DataSource = ds.Tables["Empleado"];
            objCitas.cmbEmpleado.DisplayMember = "Nombre";
            objCitas.cmbEmpleado.ValueMember = "IdEmpleados";

            DAOCitas DAOCITAS = new DAOCitas();
            DataSet CB = DAOCITAS.LLenarcomboBOXmascota();
            objCitas.cmbMascotas.DataSource = CB.Tables["Mascota"];
            objCitas.cmbMascotas.DisplayMember = "Nombre";
            objCitas.cmbMascotas.ValueMember = "IdMascota";

            objCitas.cmbEstado.Enabled = true;

            objCitas.cmbEstado.Items.Clear();

            objCitas.cmbEstado.Items.Add(new KeyValuePair<string, int>("Activo", 1));
            objCitas.cmbEstado.Items.Add(new KeyValuePair<string, int>("Inactivo", 2));

            objCitas.cmbEstado.DisplayMember = "Key";

            objCitas.cmbEstado.ValueMember = "Value";

            objCitas.cmbEstado.SelectedIndex = 0; // Esto selecciona "Activo" por defecto

            // Evita acceder al SelectedItem inmediatamente después de la carga
            objCitas.cmbEstado.SelectedIndexChanged += (s, ev) =>
            {
                if (objCitas.cmbEstado.SelectedItem != null)
                {
                    int estadoSeleccionado = ((KeyValuePair<String, int>)objCitas.cmbEstado.SelectedItem).Value;
                }
            };
        }
        private void AgregarCitas(object sender, EventArgs e)
        {

            try
            {
                if (!(string.IsNullOrEmpty(objCitas.cmbEmpleado.Text.Trim()) ||
                string.IsNullOrEmpty(objCitas.cmbMascotas.Text.Trim()) ||
                string.IsNullOrEmpty(objCitas.cmbEstado.Text.Trim()) ||
                string.IsNullOrEmpty(objCitas.dtpFecha.Text.Trim()) ||
                string.IsNullOrEmpty(objCitas.dtpHora.Text.Trim()) ||
                string.IsNullOrEmpty(objCitas.txtDescripcion.Text.Trim())))
                {
                    DAOCitas DAOInsert = new DAOCitas();
                    DAOInsert.IdEmpleados = int.Parse(objCitas.cmbEmpleado.SelectedValue.ToString());
                    DAOInsert.IdMascota1 = int.Parse(objCitas.cmbMascotas.SelectedValue.ToString());
                    DAOInsert.Fecha = objCitas.dtpFecha.Value.Date;
                    DAOInsert.Hora = objCitas.dtpHora.Value.TimeOfDay;
                    DAOInsert.Descripcion = objCitas.txtDescripcion.Text.Trim();

                    int estadoSeleccionado = ((KeyValuePair<string, int>)objCitas.cmbEstado.SelectedItem).Value;
                    DAOInsert.ESTADOCITA1 = estadoSeleccionado == 1;



                    int valorRetornado = DAOInsert.Registarcitas(); // Registra el nuevo usuario
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
