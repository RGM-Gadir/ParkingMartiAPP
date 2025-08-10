using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingMartiAPP.Clases
{
    public class Facturas
    {
        [Key]
        public int idFactura { get; set; }
        public int NumeroDeFactura { get; set; }
        public DateTime Fecha { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal IVA { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal BaseImponible { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Retencion { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal ImporteTotal { get; set; }
        public string? MetodoDePago { get; set; }
        public string? Descripcion1 { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal precio1 { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal precio2 { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal precio3 { get; set; }
        public int cantidad1 { get; set; }
        public int cantidad2 { get; set; }
        public int cantidad3 { get; set; }
        public string? Descripcion2 { get; set; }
        public string? Descripcion3 { get; set; }
        public string? Descripcion4 { get; set; }
        public string? Descripcion5 { get; set; }
        public string? QuiereMatriculas { get; set; }
        public DateTime FechaOperacion { get; set; }


        [ForeignKey("IdCliente")]
        public int? ClienteID { get; set; }

        [ForeignKey("IdProveedor")]
        public int? ProveedorID { get; set; }

        public int numeroProforma { get; set; }

        public int ConvertidaAVerifactu {  get; set; }
    }
}
