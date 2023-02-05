using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Exam.Models
{
    public class CourseAssignment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("CourseID")]
        public int CourseID { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
    }
}
