using System.ComponentModel.DataAnnotations;

namespace Day6task.Models
{
    public class uniquecourseAttribute : ValidationAttribute
    {
        Centerdbcontext Centerdbcontext = new Centerdbcontext();
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            Course course = validationContext.ObjectInstance as Course;
            string name = value.ToString();
            var Course = Centerdbcontext.Courses.Where(a => a.Isdeleted == false).
                FirstOrDefault(a => a.name == name && a.departmentid == course.departmentid);
            if (Course == null) { 
                return ValidationResult.Success;
            }
            return new ValidationResult("course already exists in this depatment "); 
        }
    }
}
