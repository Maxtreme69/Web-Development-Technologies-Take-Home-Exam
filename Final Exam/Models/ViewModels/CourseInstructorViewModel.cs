using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Final_Exam.Models.ViewModels
{
    public class CourseInstructorViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Student> Students { get; set; }

        public string Title { get; set; }

        public string FirstMidName { get; set; }
    }
}
