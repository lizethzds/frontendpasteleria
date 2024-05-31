using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace frontendnet.Models
{
    public class Producto
    {
        [Display(Name = "ID Producto")]
        public int? ProductoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.Currency)]
        [Range(0.01, double.MaxValue, ErrorMessage = "El valor del campo {0} debe ser mayor que {1}.")]
        [Display(Name = "Precio")]
        public float Precio { get; set; }
//
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; } = "Sin descripción";

        [Display(Name = "Foto")]
        public int? ArchivoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [ForeignKey("Categoria")]
        [Display(Name = "Categoría")]
        public int CategoriaId { get; set; }

       
    }
}
