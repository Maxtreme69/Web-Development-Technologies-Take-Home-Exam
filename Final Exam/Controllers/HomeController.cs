/*using AspNetCore;
*/
using Final_Exam.Data;
using Final_Exam.Models;
using Final_Exam.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System.Diagnostics;
using X.PagedList;


namespace Final_Exam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        // Instantiate object of course and instructors
        List<Course> course2List = new List<Course>();
        List<Instructor> instructor2List = new List<Instructor>();

        // Controller for Course Instructor table
        public ActionResult CourseInstructor2()
        {
            /*            insertDummyData();
            */            /*  var courstInstructorViewModel2 = from c in course2List
                                                           join i in instructor2List on c.CourseID equals i.ID into ci
                                                           from i in ci.DefaultIfEmpty()
                                                           select new CourseInstructorViewModel2 { course2 = c, instructor2 = i };
                          return View(courstInstructorViewModel2);*/

            /*       List<Course> courses = _context.Courses.ToList();
                   List<Instructor> instructors = _context.Instructors.ToList();
                   List<Student> students = _context.Students.ToList();*/
            /*
                        from e in employees
                        join d in departments on e.Department_Id equals d.DepartmentId into table1
                        from d in table1.ToList()
                        join i in incentives on e.Incentive_Id equals i.IncentiveId into table2
                        from i in table2.ToList()*/
            /*
                         var coursetInstructorViewModel2  = from c in _context.Courses
                                                            join i in _context.Instructors on c.DepartmentID equals i.ID into ci
                                                            from i in ci.ToList()
                                                            join s in students on c.DepartmentID equals s.ID into si
                                                            from s in si.ToList()
                                                            select new CourseInstructorViewModel2
                                                            {
                                                               course2 = c,
                                                               instructor2 = i,
                                                               student2 = s
                                                            };*/

            // Joins Course and instructor tables together and parses table to view
            var coursetInstructorViewModel2 = from c in _context.Courses
                                             join i in _context.Instructors on c.CourseID equals i.ID into ci
                                             from i in ci.DefaultIfEmpty()
                                             select new CourseInstructorViewModel2 { course2 = c, instructor2 = i };
            return View(coursetInstructorViewModel2);
        }

        public void insertDummyData()
        {
            //--- Insert Dummy data into Student
            course2List.Add(new Course { CourseID = 1, Title = "Biology"});
            

            //---- Insert Dummy data into StudentAdditionalInfo
            instructor2List.Add(new Instructor { ID = 1, FirstMidName = "Max" });


        }

        public ActionResult CourseInstructor()
        {
            var model = new CourseInstructorViewModel
            {
                Courses = _context.Courses.ToList(),
                Instructors = _context.Instructors.ToList(),
                Students = _context.Students.ToList()
            };

 /*           var results = (from p in _context.Courses
                           join ps in _context.Instructors on p.Title equals ps.FirstMidName
                           select new CourseInstructorViewModel()
                           {
                               Title = p.Title,
                               FirstMidName = ps.FirstMidName,
                           }).ToList();
*/
        /*    var results = (from p in db.Project
                           join ps in db.ProjectStatus on p.Status equals ps.Id
                           select new ProjectViewModel()
                           {
                               ProjectName = p.ProjectName,
                               Status = ps.StatusName,
                               Percent = ps.PercentComplete
                           }).ToList();*/

            return View(model);
        }

        /*      public HomeController(ILogger<HomeController> logger)
              {
                  _logger = logger;
              }*/

        public async Task<IActionResult> PaginationInstructor(int page = 1, int pageSize = 2)
        {

            var items = await _context.Courses.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            var pagedList = await _context.Instructors.OrderBy(x => x.ID).ToPagedListAsync(page, pageSize);

            return View(pagedList);
        }


  

        public IActionResult Index()
        {
            return View();
        }

   



        /*   public async Task<IActionResult> CourseInstructor()
           {
               CourseInstructorViewModel model = new CourseInstructorViewModel();
               *//*            var titles = _context.Courses.Select(x => x.Title).Distinct().OrderBy(x => x);
               *//*
               return View(model);
           }*/


        /*public ViewResult CourseInstructor()
        {
            CourseInstructorViewModel model = new CourseInstructorViewModel();
            return View(model);
        }
*/
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}