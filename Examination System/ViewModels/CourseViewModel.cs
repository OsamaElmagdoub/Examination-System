using Examination_System.Models;

namespace Examination_System.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }


    }
    public static class CourseViewModelExtensions
    {
        public static CourseViewModel ToViewModel(this Course course)
        {
            return new CourseViewModel
            {
                Id = course.Id,
                Name = course.Name,

            };

        }
        public static IEnumerable<CourseViewModel> ToViewModels(this IQueryable<Course> courses)
        {
            return courses.Select(x => x.ToViewModel())
                .ToList();
        }
    }
}