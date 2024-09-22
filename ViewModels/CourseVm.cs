using Day6task.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6task.ViewModels
{
    public class CourseVm
    {
        public int id { get; set; }
        [DisplayName("course name ")]
        public string name { get; set; }

        [DisplayName(" degree ")]
        [Remote("comparewithDegree", "Course", AdditionalFields = "mindegree", ErrorMessage = " degree can't be greater than min degree")]
        public double degree { get; set; }

        [DisplayName("min degree")]
        public double mindegree { get; set; }


        public int departmentid { get; set; }

        public List<DepartmentVM> Departmentvm { get; set; }

    }
}
