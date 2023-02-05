using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Exam.Models
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        [StringLength(50, ErrorMessage = "Title must not exceed 50 characters"), MinLength(3, ErrorMessage = "Minimum 3 characters is required")]
        public string Title { get; set; }
        [Range(0, 5)]
        public int Credits { get; set; }
        [ForeignKey("DepartmentId")]
        public int DepartmentID { get; set; }
    }
}
