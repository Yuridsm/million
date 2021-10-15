using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Logging
    {
        [Key]
        public int Identifier { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
