using Examination_System.Data;
using Examination_System.Models;
using Examination_System.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examination_System.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        //•	Create Course: Instructors can create new courses.
        [HttpPost]
        public async void CreateCourse(Course course)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            context.Courses.Add(course);
        }
        //•	Edit Course: Instructors can edit course details.

        [HttpPut("id")]

        public async void UpdateCourse(int id)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            //await context.Courses.Update();
        }

        //•	Delete Course: Instructors can delete courses.

        [HttpDelete("id")]
        public async void DeleteCourse(int id)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            //await context.Courses.Update();
        }

        //•	Enroll Student: Students can enroll in courses.

        [HttpGet]

        public IEnumerable<CourseViewModel> GetAllCourses()
        {
            ApplicationDbContext context = new ApplicationDbContext(); 

            return context.Courses
                .Select(c =>new CourseViewModel { Name= c.Name  })
                .ToList();     
        }

        //[HttpGet("id")]

        //public IEnumerable<Course> GetCourseById(int id)
        //{
        //    ApplicationDbContext context = new ApplicationDbContext();

           



        //}



    }
}
