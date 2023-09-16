using NuGet.Protocol;
using System.ComponentModel.DataAnnotations;

namespace FinalClearance.Models
{
    public class StudentReceipt
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Person Person { get; set; }
        public Level Level { get; set; }
        public FeeType FeeType { get; set; }
        public bool IsFullTuition { get; set; }
        public Semester Semester { get; set; }
        public Session Session { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastEdited { get; set; }
        public bool IsAproved { get; set; }
        public bool IsReceiptViewed { get; set; }
        public Person ApprovedBy { get; set; }
        public DateTime Approved { get; set; }

    }
}
