using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinalClearance.Models
{
    public class Faculty
    {
        [Key]
        public long Id { get; set; }
        //[Required]
        [DisplayName("Faculty Code")]
        public string Code { get; set; }
       // [Required]
        public string Name { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;

        
    }
}
