using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMartiAPP.Clases
{
    public class Plazas
    {
        [Key]
        public int idPlaza { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("IdFactura")]
        public int? FacturaID { get; set; }
    }
}
