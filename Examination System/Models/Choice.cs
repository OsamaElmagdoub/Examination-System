namespace Examination_System.Models
{
    public class Choice : BaseModel
    {
        public string  Text { get; set; }
        public bool  IsRightAnswer { get; set; }
        public int  QuestionId { get; set; }
        public Question  Question { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

    }
}
