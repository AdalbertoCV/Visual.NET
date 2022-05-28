using System.ComponentModel.DataAnnotations;
namespace TiendaCervezas.Models{
    public class Estilo{

        [Key]
        public int Id {get; set;}
        [Required]
        [Display(Name  = "Nombre de estilo")]
        public string nombre {get;set;}
    }
}