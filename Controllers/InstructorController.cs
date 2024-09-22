using Day6task.Models;
using Day6task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Day6task.Controllers
{
    public class InstructorController : Controller
    {
        Centerdbcontext cendb = new Centerdbcontext();

        // here I didn't implement filtration for soft delete on the dbcontext using fluent api
        // so I had to make sure that whenever I go to database I return with non soft deleted data only 

        //Instructor/getallinstructors
        public IActionResult getallinstructors(int id)
        {
            var instructors = cendb.Instructors.Include(a => a.Course).Include(a => a.Department)
                .Where( a => a.Isdeleted == false && a.Course.Isdeleted == false ).ToList();
            // here if course of the instructor is deleted we are cascading it 
            return View(instructors);


        }
        //Instructor/Get_instructor_byid
        public IActionResult Get_instructor_byid(int id)
        {

            var instructor = cendb.Instructors.Include(a => a.Course).Include(a => a.Department)
                .Where(a => a.Isdeleted == false && a.Course.Isdeleted == false).FirstOrDefault(a => a.id == id);
            // here if course of the instructor is deleted we are cascading it 
            if (instructor != null)
            {
                return View(instructor);
                //return PartialView("_InstructorPartial", instructor);
                //return PartialView("_InstructorPartial", instructor);
            }
            else
            {
                return Content("dosen't exist  ");
            }
        }


        public IActionResult getcourses(int departmentId)
        {
            var courses = cendb.Courses
                .Where(a => a.departmentid == departmentId  && a.Isdeleted == false ).
                Select(a => new courseviewm {  id = a.id , name = a.name }).OrderBy(a => a.name).ToList();

            return Ok(courses);
        }

        [HttpGet]
        public IActionResult insert()
        {
            instructorvm ins = new instructorvm();
                ins.Departmentvm = cendb.Departments.Where(a => a.Isdeleted == false).
                Select(a => new DepartmentVM { id = a.id, Name = a.Name }).OrderBy(a => a.Name).ToList();


            return View(ins);

        }

        [HttpPost]
        public IActionResult insert(Instructor instructor)
        {

            if (ModelState.IsValid)
            {
                instructor.imageurl = "21.png";
                cendb.Add(instructor);
                cendb.SaveChanges();
                return RedirectToAction("getallinstructors");
            }
            instructorvm ins = new instructorvm();
            ins.Departmentvm = cendb.Departments.Where(a => a.Isdeleted == false).
            Select(a => new DepartmentVM { id = a.id, Name = a.Name }).OrderBy(a => a.Name).ToList();


            return View(ins);
        }





        [HttpGet]

            public IActionResult edit(int id)
            {
                var instructor = cendb.Instructors.
                    FirstOrDefault(a => a.id == id);
                instructorvm ins = new instructorvm();
                ins.id = instructor.id;
                ins.Name = instructor.Name;
                ins.address = instructor.address;
                ins.imageurl = instructor.imageurl;
                ins.departmentid = instructor.departmentid;
                ins.courseid = instructor.courseid;

                ins.Departmentvm = cendb.Departments.Where(a => a.Isdeleted == false).
                    Select(a => new DepartmentVM { id = a.id, Name = a.Name })
                    .OrderBy(a => a.Name ).ToList();

            ins.Coursevm = cendb.Courses.Where(a => a.departmentid == ins.departmentid  && a.Isdeleted == false )
                .OrderBy(a => a.name).Select(a => new courseviewm
                { id = a.id, name = a.name }).ToList();

            return View(ins);
            }

            [HttpPost]
            public IActionResult edit(int id, Instructor instructor)
            {
                if ( ModelState.IsValid )
                {
                    instructor.imageurl = "";
                    cendb.Instructors.Update(instructor);
                    cendb.SaveChanges();
                    return RedirectToAction("getallinstructors");

                }
                instructorvm ins = new instructorvm();
                ins.id = instructor.id;
                ins.Name = instructor.Name;
                ins.address = instructor.address;
                ins.imageurl = instructor.imageurl;
                ins.departmentid = instructor.departmentid;
                ins.courseid = instructor.courseid;

                ins.Departmentvm = cendb.Departments.Where(a => a.Isdeleted == false).
                    Select(a => new DepartmentVM { id = a.id, Name = a.Name })
                    .OrderBy(a => a.Name).ToList();

                ins.Coursevm = cendb.Courses.Where(a => a.departmentid == ins.departmentid && a.Isdeleted == false)
                    .OrderBy(a => a.name).Select(a => new courseviewm
                    { id = a.id, name = a.name }).ToList();

                return View(ins);
            }

            public IActionResult delete(int id)
            {

                    var instructor = cendb.Instructors.Include(a => a.Course).Include(a => a.Department).
                        FirstOrDefault(a => a.id == id);
                    if (instructor != null)
                    {
                        cendb.Instructors.Remove(instructor);
                    }
                        cendb.SaveChanges();
                    return RedirectToAction("Index", "Home");


            }
        public IActionResult GetDepartment(int id)
        {
           var Depar =cendb.Departments.Select(a=> new DepartmentVM { id=a.id, Name = a.Name }).ToList();
            return View(Depar);

        }

        public IActionResult GetinstructorbyDept(int DepID)
        {
            var Depar = cendb.Instructors.Where(a=>a.departmentid== DepID).ToList();
            return Json(Depar);

        }

    }
    }

