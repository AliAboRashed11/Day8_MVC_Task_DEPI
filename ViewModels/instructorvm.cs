using Day6task.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Day6task.ViewModels
{
    public class instructorvm
    {
        public int id { get; set; }

        [DisplayName("enter insturtor name")]
        public string Name { get; set; }

        [DisplayName("enter your photo")]
        public string imageurl { get; set; }

        [DisplayName("enter instructor address")]
        public string address { get; set; }

        [DisplayName("choose your  department ")]
        public int departmentid { get; set; }

        [DisplayName("choose course ")]

        public int courseid { get; set; }


        public List<DepartmentVM> Departmentvm { get; set; }

        public List<courseviewm> Coursevm { get; set; } = new List<courseviewm>();
    }
}
