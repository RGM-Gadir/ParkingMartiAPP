using System.ComponentModel.DataAnnotations;

namespace ParkingMartiAPP.Clases
{
    public class Proveedores
    {
        [Key]
        public int idProveedor { get; set; }
        public string NombreYApellidos { get; set; }
        public string? CIF { get; set; }
        public string? Direccion { get; set; }
        public string? Poblacion { get; set; }
        public string? Correo { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public virtual ICollection<Facturas>? Facturas { get; set; }

    }
}
