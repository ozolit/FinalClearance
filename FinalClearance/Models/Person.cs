using System.ComponentModel.DataAnnotations;

namespace FinalClearance.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Reg Number")]
        public string RegNumber { get;set; }
        [Display(Name = "First Name")]

        public string FirstName { get; set; }
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Display(Name = "Other Name")]

        public string OtherName { get; set; }
        [Display(Name = "Phone Number")]

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Display(Name = "Residential Address")]

        public string Address { get; set; }
        public AdmissionType AdmissionType { get; set; }
        public Semester Semester { get; set; }
        public Session Session { get; set; }
        public Level Level { get; set; }
        public Faculty Faculty { get; set; }
        public Department Department { get; set; }
        public Programme Programme { get; set; }
        public PersonType personType { get; set; }
        [Display(Name = "Next Of Kin Full Name")]

        public string NextOfKinName { get; set; }
        [Display(Name = "Next Of Kin Phone Number")]

        public string NextOfKinPhoneNumber { get; set; }
        [Display(Name = "Next Of Kin Address")]

        public string NextOfKinAddress { get; set; }
        [Display(Name ="Relationship")]
        public string NextOfKinRelationship { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}
