using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalClearance.Models
{
    public class Department
    {
        [Key]
        public long Id { get; set; }
        //[Required]
        public string Name { get; set; }
        [Display(Name ="Department Code")]
        public string Code { get; set; }
        //[Required]
        [Display(Name = "FacultyId Code")]

        public long FacultyId { get; set; }
        //[Required]
        public Faculty Faculty { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
