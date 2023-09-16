using System.ComponentModel.DataAnnotations;

namespace FinalClearance.Models
{
    public class AdmissionType
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
