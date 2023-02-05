using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Exam.Models
{
    public enum Grade
    {
        HighDistinction = 'A',
        Distinction = 'B',
        Credit = 'C',
        Pass = 'D',
        Fail = 'E',
        CompleteFail = 'F'
    }
    public class Enrollment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EnrollmentID { get; set; }
        [ForeignKey("CourseID")]
        public int CourseID { get; set; }
        public Grade? Grade { get; set; }
    }
}
