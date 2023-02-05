using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PagedList;


namespace Final_Exam.Models;

public class Instructor
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ID { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Last Name cannot be more than 50 characters")]
    [RegularExpression("^[A-Z][a-zA-Z]*$", ErrorMessage = "The first character must be upper case and the remaining charcters alphabetical characters")]
    public string? LastName { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "First Name cannot be more than 50 characters")]
    [RegularExpression("^[A-Z][a-zA-Z]*$", ErrorMessage = "The first character must be upper case and the remaining charcters alphabetical characters")]
    public string? FirstMidName { get; set; }
    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Hire Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime HireDate { get; set; }


}
