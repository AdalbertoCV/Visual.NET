using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TiendaCervezas.Models{
    public class Cerveza{

        [Key]
        public int Id {get; set;}
        [Required]
        [Display(Name ="Nombre Cerveza")]
        public string nombre{get;set;}
        [Display(Name = "Estilo")]
        public int IdEstilo {get;set;}
        [ForeignKey("IdEstilo")]
        public Estilo? estilo {get;set;}
        [Required]
        [Display(Name ="% de Alcohol")]
        public double Alcohol {get;set;}
        [Display(Name ="Precio")]
        public double? Precio {get;set;}
        [Display(Name ="Imagen de la cerveza:")]
        public string URLImagen {get;set;}
    }
}