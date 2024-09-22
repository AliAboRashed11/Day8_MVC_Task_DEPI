using Day6task.Models;
using Day6task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;

namespace Day6task.Controllers
{
    public class CourseController : Controller
    {
        Centerdbcontext cendb = new Centerdbcontext();

        public IActionResult Index()
        {
            return View();
        }

        //Course/Getallcourses
        public IActionResult Getallcourses()
        {
            var courses = cendb.Courses.Include( a => a.Department).Where( a => a.Isdeleted == false ) .ToList();
            return View(courses);
        }

        //Course/get_course_byId
        public IActionResult get_course_byId(int id)
        {
            var course = cendb.Courses.Include(a => a.Department)
                .Where( a => a.Isdeleted == false ). FirstOrDefault( a => a.id == id );
            if (course != null)
            {
                return View(course);
            }
            else
            {
                return Content("course dosen't exisit"); 
            }
        }

        [HttpGet]
        public IActionResult edit(int id)
        {
            var course = cendb.Courses.FirstOrDefault(a  => a.id == id);

            CourseVm coursevm = new CourseVm();
            coursevm.id = course.id; 
            coursevm.name = course.name;
            coursevm.mindegree= course.mindegree;
            coursevm.degree = course.degree;
            coursevm.departmentid = course.departmentid;
            coursevm.Departmentvm = cendb.Departments.Where( a => a.Isdeleted == false ).
            Select( a => new DepartmentVM { id = a.id , Name = a.Name} ).OrderBy( a => a.Name).ToList();

            return View(coursevm);

        }

        [HttpPost]
        public IActionResult edit(int id, Course course)
        {
            if (ModelState.IsValid)
            {

                cendb.Courses.Update(course);
                cendb.SaveChanges();
                return RedirectToAction("Getallcourses");

            }
            CourseVm coursevm = new CourseVm();
            coursevm.id = course.id;
            coursevm.name = course.name;
            coursevm.mindegree = course.mindegree;
            coursevm.degree = course.degree;
            coursevm.departmentid = course.departmentid;
            coursevm.Departmentvm = cendb.Departments.Where(a => a.Isdeleted == false).
            Select(a => new DepartmentVM { id = a.id, Name = a.Name }).OrderBy(a => a.Name).ToList();
            return View(coursevm);
        }

        [HttpGet]
        public IActionResult  insert()
        {
            CourseVm coursevm = new CourseVm();
            coursevm.Departmentvm = cendb.Departments.Where(a => a.Isdeleted == false).
            Select(a => new DepartmentVM { id = a.id, Name = a.Name }).OrderBy(a => a.Name).ToList();
            return View(coursevm); 
        }

        [HttpPost]

        public IActionResult insert( Course course )
        {
            if (ModelState.IsValid )
            {
                cendb.Courses.Add(course);
                cendb.SaveChanges();
                return RedirectToAction("Getallcourses");

            }
            CourseVm coursevm = new CourseVm();
            coursevm.Departmentvm = cendb.Departments.Where(a => a.Isdeleted == false).
            Select(a => new DepartmentVM { id = a.id, Name = a.Name }).OrderBy(a => a.Name).ToList();
            return View(coursevm);
        }



        public IActionResult delete(int id) {

            var course = cendb.Courses.Include(a => a.Department).
                FirstOrDefault(a => a.id == id);
            if (course != null)
            {
                cendb.Remove(course);
            }
            cendb.SaveChanges();
            return RedirectToAction("Index", "Home");

        }

        public IActionResult comparewithDegree(int mindegree, int degree) { 
            if( degree <= mindegree)
            {
                return Json(true); 
            }
            return Json(false);
        }
    }
}
