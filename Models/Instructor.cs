using Day6task.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6task.Models
{
    public class Instructor  : Isoftdelete
    {
        public int id { get; set; }

        [uniqueinstructor]
        public string Name { get; set; }
        public string imageurl { get; set; }
        public string address { get; set; }
        [ForeignKey("department")]
        public int departmentid { get; set; }
        [ForeignKey("course")]
        public int courseid { get; set; }


        public bool Isdeleted { get; set; } = false;

        public virtual Course ? Course { get; set; }

        public virtual Department ? Department { get; set; }
    }
}
