namespace Examination_System.Models
{
    public class Exam : BaseModel
    {
        public DateTime StartDate { get; set; } 
        public int TotalGrade { get; set; } 
        public int CourseId { get; set; } 
        public Course Course { get; set; } 
        public int InstructorId { get; set; } 
        public Instructor Instructor { get; set; }
        public List<StudentExam> StudentExams { get; set; }

        public HashSet<ExamQuestion> ExamQuestions { get; set; }


    }
}
