using Day6task.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6task.Models
{
    public class Course  : Isoftdelete
    {
        public int id { get; set; }

        [uniquecourse]
        public string name { get; set; }

        [Remote("comparewithDegree" , "Course" , AdditionalFields = "mindegree" , ErrorMessage =" degree can't be greater than min degree")]
        public double degree { get; set; }
        public double mindegree { get; set; }


        [ForeignKey("department")]
        public int departmentid { get; set; }

        public bool Isdeleted {  get; set; } = false;

        public virtual ICollection<CourseResult> ? CourseResults { get; set; }

        public virtual Department ? Department { get; set; }
        public virtual ICollection<Instructor> ? Instructors { get; set; }

    }
}
