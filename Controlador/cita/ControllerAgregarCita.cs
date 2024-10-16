﻿using Proyecto.Modelo.DAO;
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
        int IdCitas;
        int IdEmpleados;
        int IdMascota;
        DateTime Fecha;
        TimeSpan Hora;
        string Descripcion;

        public ControllerAgregarCita(frmcitas vista)
        {
            objCitas = vista;
            objCitas.Load += new EventHandler(iniciar);
            objCitas.btnIngresar.Click += new EventHandler(AgregarCitas);
        }

        public ControllerAgregarCita(frmcitas vista, int IdCitas, int IdEmpleados, int IdMascota, DateTime Fecha, TimeSpan Hora, string Descripcion)
        {
            objCitas = vista;
            objCitas.Load += new EventHandler(iniciar);
            objCitas.btnIngresar.Click += new EventHandler(AgregarCitas);
            objCitas.btnActualizar.Click += new EventHandler(ActualizarCitas);
        }

        void CargarDatosActualizar()
        {
            CargarDatos(IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        }

        public void CargarDatos(int IdCitas, int IdEmpleados, int IdMascota, DateTime Fecha, TimeSpan Hora, string Descripcion)
        {
            objCitas.cmbEmpleado.SelectedValue = IdEmpleados;
            objCitas.txtDescripcion.Text = Descripcion;
            CargarDatos(IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        }

        private void ActualizarCitas(object sender, EventArgs e)
        {

        }

        private void iniciar(object sender, EventArgs e)
        {
            LLenarcomboEmpleados();

        }

        void LLenarcomboEmpleados()
        {

            DAOCitas daoCitas = new DAOCitas();
            DataSet ds = daoCitas.LLenarcomboEmpleados();
            objCitas.cmbEmpleado.DataSource = ds.Tables["Empleado"];
            objCitas.cmbEmpleado.DisplayMember = "Nombre";
            objCitas.cmbEmpleado.ValueMember = "IdEmpleados";
        }
        private void AgregarCitas(object sender, EventArgs e)
        {

            try
            {
                // Crear una nueva instancia de DAOCitas para insertar
                DAOCitas daoInsert = new DAOCitas();

                int IdEmpleados = int.Parse(objCitas.cmbEmpleado.SelectedValue.ToString()); // ID del empleado
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
