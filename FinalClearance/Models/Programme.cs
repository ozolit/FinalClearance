using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalClearance.Models
{
    public class Programme
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Programme Code")]
        public string Code { get; set; }
        [Required]
        [Display(Name = "Faculty")]
        public long FacultyId { get; set; }
        [Required]
        [Display(Name = "Department")]
        public long DepartmentId { get; set; }
        [Required]
        public Faculty Faculty { get; set; }
        [Required]
        public  Department Department { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;   
    }
}
