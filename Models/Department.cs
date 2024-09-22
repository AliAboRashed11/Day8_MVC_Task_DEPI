using Day6task.Models;

namespace Day6task.Models
{
    public class Department : Isoftdelete
    {

        public int id { get; set; }
        public string Name { get; set; }
        public string manager { get; set; }


        public bool Isdeleted { get; set; } = false;

        public virtual ICollection<Trainee> Traines { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }

    }
}
