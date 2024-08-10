using Examination_System.Data;
using Examination_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Examination_System.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        //•	Add Question: Instructors can add questions to quizzes.
        //•	Edit Question: Instructors can edit questions.
        //•	Delete Question: Instructors can delete questions.

        //[HttpGet("id")]

        //public Question GetQuestionById(int id)
        //{
        //    ApplicationDbContext context = new ApplicationDbContext();

        //    Question qst = context.Questions.Where(q => q.Id == id)
        //        .Include(q=>q.Choices)
        //        .FirstOrDefault();

        //    return qst;



        //}
    }
}
