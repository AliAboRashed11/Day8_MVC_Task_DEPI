using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Day6task.Models
{
    public class uniqueinstructorAttribute : ValidationAttribute
    {
        Centerdbcontext centerdbcontext = new Centerdbcontext();

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            Instructor instructor = validationContext.ObjectInstance as Instructor;
            string name = value.ToString();
            var inst = centerdbcontext.Instructors.Include(a => a.Department).Include(a => a.Course)
                .Where(a => a.Isdeleted == false && a.Course.Isdeleted == false).
                FirstOrDefault(a => a.Name == name && a.departmentid == instructor.departmentid);

            if (inst == null) {
                return ValidationResult.Success; 
            }
            return new ValidationResult("instructor already exists in this department "); 
        }
    }
}
