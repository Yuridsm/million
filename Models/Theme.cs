using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Theme
    {
        [Key]
        public int Id { get;set; }
        
        [Required(ErrorMessage="Preencha este campo")]
        public string Name { get;set; }
    }
}