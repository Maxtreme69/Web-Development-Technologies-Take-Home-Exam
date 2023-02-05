using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Exam.Models
{
    public class OfficeAssignment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("InstructorID")]
        public int InstructorID { get; set; }
        [StringLength(50, ErrorMessage = "Location cannot be more than 50 characters")]
        public string? Location { get; set;}
    }
}