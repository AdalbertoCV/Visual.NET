using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Examen3.Models{
    public class Bebida{

        [Key]
        public int Id {get;set;}
        [Required]
        [Display(Name ="Nombre Bebida")]
        public string? nombre {get;set;}
        [Required]
        [Display(Name ="Tipo Bebida")]
        public string? tipo{get;set;}
        [Required]
        [Display(Name ="Precio")]
        public  double? precio{get;set;}
        public string? urlImagen{get;set;}
    
    }
}