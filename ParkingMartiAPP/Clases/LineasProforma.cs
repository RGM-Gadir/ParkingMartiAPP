using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMartiAPP.Clases
{
    public class LineasProforma
    {
        [Key]
        public int idLinea { get; set; }

        public int idProforma { get; set; }

        public int idLineaEnProforma { get; set; }

        public string? Descripcion { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal precio1 { get; set; }

        public int cantidad1 { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal IVA { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal BaseImponible { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Retencion { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal ImporteTotal { get; set; }
    }
}
