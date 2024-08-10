namespace Examination_System.Models
{
    public class Student : BaseModel
    {

        public string Name { get; set; }

        public List<StudentExam> StudentExams { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }

    }
}
