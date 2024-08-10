namespace Examination_System.Models
{
    public class Instructor : BaseModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Exam> Exams  { get; set; }
        public List<Question> Questions  { get; set; }
        public List<Choice> Choices  { get; set; }
        public List<CourseInstructor> CourseInstructors  { get; set; }
    }
}
