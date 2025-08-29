using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ParkingMartiAPP.Clases
{
    public class Vehiculos
    {
        [Key]
        public int idVehiculo { get; set; }
        public string Matricula { get; set; }
        public int tipoVehiculo { get; set; }

        [ForeignKey("IdCliente")]
        public int ClienteID { get; set; }


    }
}
