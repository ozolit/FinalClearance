using System.ComponentModel.DataAnnotations;

namespace FinalClearance.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public StudentReceipt StudentReceipt { get; set; }
        public bool IsCommentRead { get; set; }
        public Person CommentedBy { get; set; }
        public DateTime Commented { get; set; }
    }
}
