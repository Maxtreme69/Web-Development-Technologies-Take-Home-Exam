using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Exam.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        [StringLength(50, ErrorMessage = "Name must not exceed 50 characters"), MinLength(3, ErrorMessage = "Minimum Length of 3 characters required")]
        public string? Name { get; set; }
        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public decimal Budget { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [ForeignKey("InstructionID")]
        public int InstructorID { get; set; }
    }
}
