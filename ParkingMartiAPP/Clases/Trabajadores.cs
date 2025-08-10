using System.ComponentModel.DataAnnotations;

namespace ParkingMartiAPP.Clases
{
    public class Trabajadores
    {
        [Key]
        public int idTrabajador { get; set; }
        public string? NombreYApellidos { get; set; }
        public string? CIF { get; set; }
        public string? Direccion { get; set; }
        public string? Poblacion { get; set; }
        public string? Correo { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public int diasTrabajados { get; set; }
        public int horasTrabajadas { get; set; }
        public int vacaciones {  get; set; }

        public int numeroSeguridasSocial { get; set; }


    }
}
