using Proyecto.Vista.InterfazCitas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Modelo.DAO;
using System.Windows.Forms;
using System.Data;

namespace Proyecto.Controlador.Citas
{
    internal class ControllerAgregarCitas
    {
        frmAgregarCitas objCitas;
        int IdCitas;
        int IdEmpleados;
        int IdMascota;
        DateTime Fecha;
        TimeSpan Hora;
        string Descripcion;

        public ControllerAgregarCitas(frmAgregarCitas vista)
        {
            objCitas = vista;
            objCitas.Load += new EventHandler(iniciar);
            objCitas.btnAgregar.Click += new EventHandler(AgregarCitas);
        }

        public ControllerAgregarCitas(frmAgregarCitas vista, int IdCitas, int IdEmpleados, int IdMascota, DateTime Fecha, TimeSpan Hora, string Descripcion)
        {
            objCitas = vista;
            objCitas.Load += new EventHandler(iniciar);
            objCitas.btnAgregar.Click += new EventHandler(AgregarCitas);
            objCitas.btnActualizar.Click += new EventHandler(ActualizarCitas);
        }

        void CargarDatosActualizar()
        {
            CargarDatos(IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        }

        public void CargarDatos(int IdCitas, int IdEmpleados, int IdMascota, DateTime Fecha, TimeSpan Hora, string Descripcion)
        {
            objCitas.cmbIdEmpleados.SelectedValue = IdEmpleados;
            objCitas.txtDescripcion.Text = Descripcion;
            CargarDatos(IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        }

        private void ActualizarCitas(object sender, EventArgs e)
        {

        }
        void LlenarComboMascotas() 
        {

            DAOCitas daoCitas = new DAOCitas();
            DataSet ds = daoCitas.LlenarComboMascotas();
            objCitas.cmbIdEmpleados.DataSource = ds.Tables["mascota"];
            objCitas.cmbIdEmpleados.DisplayMember = "Nombre";
            objCitas.cmbIdEmpleados.ValueMember = "IdMascota";
        }

        private void Iniciar(object sender, EventArgs e)
        {
            LlenarComboMascotas();

        }

        public void Cargardatos(int IdCitas, int IdEmpleados, int IdMascota, DateTime Fecha, TimeSpan Hora, string Descripcion)
        {
            objCitas.cmbIdEmpleados.SelectedValue = IdMascota;
            objCitas.txtDescripcion.Text = Descripcion;
            Cargardatos(IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        }

        private void iniciar(object sender, EventArgs e)
        {
            LLenarcomboEmpleados();
            
        }

        void LLenarcomboEmpleados()
        {

            DAOCitas daoCitas = new DAOCitas();
            DataSet ds = daoCitas.LLenarcomboEmpleados();
            objCitas.cmbIdEmpleados.DataSource = ds.Tables["Empleado"];
            objCitas.cmbIdEmpleados.DisplayMember = "Nombre";
            objCitas.cmbIdEmpleados.ValueMember = "IdEmpleados";
        }
        private void AgregarCitas(object sender, EventArgs e)
        {
        
                try
                {
                    // Crear una nueva instancia de DAOCitas para insertar
                    DAOCitas daoInsert = new DAOCitas();

                    int IdEmpleados = int.Parse(objCitas.cmbIdEmpleados.SelectedValue.ToString()); // ID del empleado
                    string IdMascota = objCitas.cmbMascotas.Text.Trim(); // ID de la mascota
                    DateTime Fecha = DateTime.Parse(objCitas.dtpFecha.Value.ToString("yyyy-MM-dd")); // Fecha de la cita
                    TimeSpan Hora = TimeSpan.Parse(objCitas.dtpHora.Value.ToString("HH:mm:ss")); // Hora de la cita
                    string Descripcion = objCitas.txtDescripcion.Text; // Descripción de la cita

                    daoInsert.IdEmpleados = IdEmpleados;
                    daoInsert.Fecha = Fecha;
                    daoInsert.Hora = Hora;
                    daoInsert.Descripcion = Descripcion;
                    daoInsert.IdMascota1 = IdMascota;
                    // Llamar al método de inserción y verificar el resultado
                    int retorno = daoInsert.IngresarCita();
                    if (retorno == 1)
                    {
                        MessageBox.Show("La cita se agregó exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la cita", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores al agregar la cita
                    MessageBox.Show("Error al agregar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
    }
}
