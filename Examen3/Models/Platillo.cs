using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Examen3.Models{
    public class Platillo{

        [Key]
        public int Id {get;set;}
        [Required]
        [Display(Name ="Nombre Platillo")]
        public string? nombre {get;set;}
        [Required]
        [Display(Name ="Ingredientes")]
        public string? ingredientes{get;set;}
        [Required]
        [Display(Name ="Precio")]
        public  double? precio{get;set;}
        [Required]
        [Display(Name ="Cantidad por plato")]
        public int? cantidad{get;set;}
        public string? urlImagen{get;set;}
    
    }
}