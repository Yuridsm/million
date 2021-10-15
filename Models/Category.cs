using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
   [Table("categories")]
    public class Category {
      [Key]
      [Column("identifier")]
      public int Identifier { get; set; }

      [Required(ErrorMessage = "Este campo é obrigatório")]
      [MaxLength(60, ErrorMessage="Este campo deve conter entre 3 e 60 caracteres")]
      [MinLength(3, ErrorMessage="Este campo deve conter entre 3 e 60 caracteres")]
      [Column("title")]
      public string Title { get; set; }
      public List<Product> Products { get; set; }
   } 
}
