using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Examen3.Models{
    public class Postre{

        [Key]
        public int Id {get;set;}
        [Required]
        [Display(Name ="Nombre Postre")]
        public string? nombre {get;set;}
        [Required]
        [Display(Name ="Ingredientes")]
        public string? ingredientes{get;set;}
        [Required]
        [Display(Name ="Precio")]
        public  double? precio{get;set;}
        public string? urlImagen{get;set;}
    
    }
}