﻿using Proyecto.Controlador.Validar;
using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Proveedor
{
    internal class ControllerAgregarProveedor
    {
        frmAgregarProveedor ObjAgregar;
        private int accion;

        public ControllerAgregarProveedor(frmAgregarProveedor objAgregar, int accion)
        {
            ObjAgregar = objAgregar;
            this.accion = accion;

            verificarAccion(); // Verifica la acción para habilitar o deshabilitar controles según la acción
            ObjAgregar.btnIngresarProveedor.Click += new EventHandler(NuevoRegistro); // Asocia el evento Click del botón Ingresar al método NuevoRegistro

        }

        public ControllerAgregarProveedor(frmAgregarProveedor Vista, int p_accion, int id, string Nombre)
        {
            ObjAgregar = Vista;
            this.accion = p_accion;
            verificarAccion(); // Verifica la acción para habilitar o deshabilitar controles según la acción
            CambiarValores(id, Nombre); // Carga los datos del usuario en el formulario

            ObjAgregar.btnActualizarProveedor.Click += new EventHandler(ActualizarDatos); // Asocia el evento Click del botón Actualizar al método ActualizarDatos
        }

        public void verificarAccion()
        {
            if (accion == 1) // Acción de agregar nuevo usuario
            {
                ObjAgregar.btnIngresarProveedor.Enabled = true;
                ObjAgregar.btnActualizarProveedor.Enabled = false;
                ObjAgregar.btnCancelar.Enabled = true;
            }
            else if (accion == 2) // Acción de editar usuario
            {
                ObjAgregar.btnIngresarProveedor.Enabled = false;
                ObjAgregar.btnActualizarProveedor.Enabled = true; 
            }
            //else if (accion == 3) // Acción de solo lectura
            //{
            //    ObjAgregarUsuario.btnIngresar.Enabled = false;
            //    ObjAgregarUsuario.btnActualizar.Enabled = false;
            //    ObjAgregarUsuario.txtNombre.Enabled = false;
            //    ObjAgregarUsuario.txtApellido.Enabled = false;
            //    ObjAgregarUsuario.txtCorreo.Enabled = false;
            //    ObjAgregarUsuario.dtpNacimiento.Enabled = false;
            //    ObjAgregarUsuario.txtUsuario.Enabled = false;
            //    ObjAgregarUsuario.cmbRoles.Enabled = false;
            //}
        }

        public void NuevoRegistro(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(ObjAgregar.txtProveedor.Text.Trim())))
                {
                    DAOProveedor DAOInsert = new DAOProveedor();
                    DAOInsert.Proveedor = ObjAgregar.txtProveedor.Text.Trim();



                    int valorRetornado = DAOInsert.RegistarProveedor(); // Registra el nuevo usuario
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

        public void ActualizarDatos(object sender, EventArgs e)
        {
            DAOProveedor daoUpdate = new DAOProveedor();
            daoUpdate.IdProveedor1 = int.Parse(ObjAgregar.txtIdProveedor.Text.Trim());
            daoUpdate.Proveedor = ObjAgregar.txtProveedor.Text.Trim();
            int valorRetornado = daoUpdate.ActualizarProveedor(); // Actualiza el usuario
            if (valorRetornado == 2)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos no pudieron ser actualizados completamente",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void CambiarValores(int id, string Nombre)
        {
            try
            {
                ObjAgregar.txtIdProveedor.Text = id.ToString();
                ObjAgregar.txtProveedor.Text = Nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}"); // Muestra mensaje de error en caso de excepción
            }
        }
    }
}
