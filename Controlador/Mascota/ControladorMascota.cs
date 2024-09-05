using Proyecto.Modelo.DAO;
using Proyecto.Modelo.DTO;
using Proyecto.Vista.AgregarMascotas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Modelo.DAO;

public class ControladorMascota
{
    
    private readonly Proyecto.Modelo.DAO.MascotaDAO mascotaDAO;
    private object _mascotaDAO;

    public string Nombre { get; private set; }
    public string Raza { get; private set; }
    public string Dueño { get; private set; }
    public double Peso { get; private set; }
    public string Genero { get; private set; }
    public DateTime FechaNacimiento { get; private set; }

    public ControladorMascota()
    {
      
    }

    public void AgregarMascota(FrmAgregarMascota form)
    {
        ControladorMascota mascota = new ControladorMascota();
        {
            Nombre = form.txtNombre.Text;
            Raza = form.txtRaza.Text;
            Dueño = form.txtDueño.Text;
            Peso = Convert.ToDouble(form.txtPeso.Text);
            Genero = form.cmbGenero.SelectedItem.ToString();
            FechaNacimiento = form.dtpFechaNacimiento.Value;
        };

        int filasAfectadas = _mascotaDAO.GuardarMascota(mascota);

        if (filasAfectadas > 0)
        {
            MessageBox.Show("Mascota agregada correctamente");
            
            form.txtNombre.Text = "";
           
        }
        else
        {
            MessageBox.Show("Error al agregar la mascota");
        }
    }

    public void ModificarMascota(FrmAgregarMascota form)
    {
       
    }

    public void EliminarMascota(int idMascota)
    {
       
    }

    
}
