using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMartiAPP.Clases
{
    public class Camiones
    {
        [Key]
        public int idCamion { get; set; }
        public string Matricula { get; set; }

        [ForeignKey("IdCliente")]
        public int ClienteID { get; set; }


    }
}
