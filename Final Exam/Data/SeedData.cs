using Final_Exam.Models;
namespace Final_Exam.Data
{
    public class SeedData
    {
        public static void initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DataContext>();
            context.Courses.AddRange(
                new Course
                {
                   CourseID = 1,
                   Title = "Business Economics",
                   Credits = 3,
                   DepartmentID = 1
                },
                new Course
                {
                    CourseID = 2,
                    Title = "Discrete Structures",
                    Credits = 4,
                    DepartmentID = 2
                },
                new Course
                {
                    CourseID = 3,
                    Title = "Gender Studies",
                    Credits = 2,
                    DepartmentID = 3
                },
                new Course
                {
                    CourseID = 4,
                    Title = "Micro Biology",
                    Credits = 4,
                    DepartmentID = 4
                },
                new Course
                {
                    CourseID = 5,
                    Title = "Pottery",
                    Credits = 4,
                    DepartmentID = 5
                }
            );

            context.CourseAssignments.AddRange(
               new CourseAssignment
               {
                   CourseID = 1,
                   InstructorID = 1
               },
               new CourseAssignment
               {
                   CourseID = 2,
                   InstructorID = 2
               },
               new CourseAssignment
               {
                   CourseID = 3,
                   InstructorID = 3
               },
               new CourseAssignment
               {
                   CourseID = 4,
                   InstructorID = 4
               },
                new CourseAssignment
                {
                    CourseID = 5,
                    InstructorID = 5
                }
            );

            context.Departments.AddRange(
                new Department
                { 
                    DepartmentID = 1,
                    Name = "Business",
                    Budget = 25000.00m,
                    StartDate = DateTime.Parse("2023/01/01"),
                    InstructorID = 1
                },
                new Department
                { 
                    DepartmentID = 2,
                    Name = "Computer Science",
                    Budget = 35000m,
                    StartDate = DateTime.Parse("2023/02/02"),
                    InstructorID = 2
                },
                new Department
                {
                    DepartmentID = 3,
                    Name = "Arts",
                    Budget = 15000m,
                    StartDate = DateTime.Parse("2023/03/03"),
                    InstructorID = 3
                },
                new Department
                { 
                    DepartmentID = 4,
                    Name = "Biology",
                    Budget = 20000,
                    StartDate = DateTime.Parse("2023/04/04"),
                    InstructorID = 4
                },
                new Department
                {
                    DepartmentID = 5,
                    Name = "Fine Arts",
                    Budget = 12500.00m,
                    StartDate = DateTime.Parse("2023/05/05"),
                    InstructorID = 5
                }
            );

            context.Enrollments.AddRange(
                new Enrollment
                { 
                    EnrollmentID = 2,
                    CourseID = 5,
                    Grade = Grade.Distinction
                },
                new Enrollment
                {
                    EnrollmentID = 5,
                    CourseID = 3,
                    Grade = Grade.Credit
                },
                new Enrollment
                {
                    EnrollmentID = 1,
                    CourseID = 4,
                    Grade = Grade.CompleteFail
                },
                new Enrollment
                {
                    EnrollmentID = 3,
                    CourseID = 1,
                    Grade = Grade.HighDistinction
                },
                 new Enrollment
                { 
                    EnrollmentID = 4,
                    CourseID = 2,
                    Grade = Grade.Fail
                }
            );

            context.Instructors.AddRange(
                new Instructor
                { 
                    ID = 1,
                    LastName = "Smith",
                    FirstMidName = "Dave",
                    HireDate = DateTime.Parse("2015/05/15")
                },
                new Instructor
                { 
                    ID = 2,
                    LastName = "Johnson",
                    FirstMidName = "Margaret",
                    HireDate = DateTime.Parse("2010/11/21")
                },
                new Instructor
                {
                    ID = 3,
                    LastName = "Sanchez",
                    FirstMidName = "Juan",
                    HireDate = DateTime.Parse("2010/11/21")
                },
                new Instructor
                {
                    ID = 4,
                    LastName = "Zhang",
                    FirstMidName = "Lee",
                    HireDate = DateTime.Parse("2002/07/30")
                },
                new Instructor
                {
                    ID = 5,
                    LastName = "David",
                    FirstMidName = "Sarah",
                    HireDate = DateTime.Parse("2023/01/05")
                }
            );

            context.OfficeAssignments.AddRange(
                new OfficeAssignment
                { 
                    InstructorID = 1,
                    Location = "RMIT Building 6"
                },
                new OfficeAssignment
                { 
                    InstructorID = 2,
                    Location = "RMIT Building 11"
                },
                new OfficeAssignment
                {
                    InstructorID = 3,
                    Location = "RMIT Building 45"
                },
                new OfficeAssignment
                {
                    InstructorID = 4,
                    Location = "RMIT Building 80"
                },
                new OfficeAssignment
                {
                    InstructorID = 5,
                    Location = "RMIT Building 1"
                }
            );

            context.Students.AddRange(
                new Student
                {
                    ID = 1,
                    LastName = "Charles",
                    FirstMidName = "Xavier",
                    EnrollmentDate = DateTime.Parse("2020/01/01")
                },
                new Student
                {
                    ID = 2,
                    LastName = "Gomez",
                    FirstMidName = "Maria",
                    EnrollmentDate = DateTime.Parse("2022/06/01")
                },
                new Student
                {
                    ID = 3,
                    LastName = "Marley",
                    FirstMidName = "Bob",
                    EnrollmentDate = DateTime.Parse("2019/01/01")
                },
                new Student
                {
                    ID = 4,
                    LastName = "Amin",
                    FirstMidName = "Mohammed",
                    EnrollmentDate = DateTime.Parse("2020/06/01")
                },
                new Student
                {
                    ID = 5,
                    LastName = "Smith",
                    FirstMidName = "Taylor",
                    EnrollmentDate = DateTime.Parse("2017/01/01")
                }
            );

            context.SaveChanges();
        }
    }
}