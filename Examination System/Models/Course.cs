namespace Examination_System.Models
{
    public class Course : BaseModel
    {
        public string  Name{ get; set; }

        public List<Exam> Exams { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<CourseInstructor> CourseInstructors{ get; set; }



    }
}
