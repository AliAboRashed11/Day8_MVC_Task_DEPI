using Day6task.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6task.Models
{
    public class CourseResult : Isoftdelete
    {
        public int id { get; set; }
        public double degree { get; set; }
        [ForeignKey("course")]
        public int courseid { get; set; }
        [ForeignKey("trainee")]


        public int traineeid { get; set; }

        public bool Isdeleted { get; set; } = false;
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
