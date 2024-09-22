using Day6task.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6task.Models
{
    public class Trainee : Isoftdelete
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string imageurl { get; set; }
        public string address { get; set; }
        public double grade { get; set; }
        [ForeignKey("department")]
        public int departmentid { get; set; }


        public bool Isdeleted { get; set; } = false;

        public virtual ICollection<CourseResult> courseresults { get; set; }

        public virtual Department Department { get; set; }
    }
}
