using Day6task.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Day6task.Models
{
    public class Centerdbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" server =. ; database = Center7 ; Integrated Security = true ;" +
                " Encrypt = false ");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //The following code will set ON DELETE NO ACTION to all Foreign Keys
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
            }

            //dataseeding 
            // departments 
            List<Department> departments = new List<Department>(){

                new Department(){id= 1 , Name = "dotnet" , manager = "rania mostafa" } ,
                new Department() {id=2 , Name = "devops" , manager = "ahmed mohsen" } ,
                new Department() {id=3,  Name = "AI" , manager = "yousef menesi"}

                };

            modelBuilder.Entity<Department>().HasData(departments);

            //courses

            List<Course> courses = new List<Course>()
            {
            new Course() { id = 1, name = "C#", degree = 40, mindegree = 60.0  , departmentid =1 },
                new Course() { id = 2, name = "SQL", degree = 30, mindegree = 40.0, departmentid = 1 },
                new Course() { id = 3, name = "MCV", degree = 60, mindegree = 80.0, departmentid = 1 },
                new Course() { id = 4, name = "Docker", degree = 40, mindegree = 60.0, departmentid = 2 },
                new Course() { id = 5, name = "Kubernets", degree = 30, mindegree = 40.0, departmentid = 2 },
                new Course() { id = 6, name = "Ansible", degree = 60, mindegree = 80.0, departmentid = 2 },
                new Course() { id = 7, name = "deep learning", degree = 40, mindegree = 60.0, departmentid = 3 },
                new Course() { id = 8, name = "data structures", degree = 30, mindegree = 40.0, departmentid = 3 },
                new Course() { id = 9, name = "python", degree = 60, mindegree = 80.0, departmentid = 3 }
            };

            modelBuilder.Entity<Course>().HasData(courses);

            List<Instructor> instructors = new List<Instructor>() {

                new Instructor(){id =1 , Name = "mohamed saber" , address = "Sedi_Beshr Alex" , imageurl = "1.jpg"
                , departmentid = 1 , courseid = 1},
                new Instructor(){id =2 , Name = "mohamed hagar" , address = " Elsheikh zayed" ,
                    imageurl = "2.jpg" , departmentid = 1 , courseid = 2},
                new Instructor(){id =3 , Name = "wael tabaey" , address = "alzahraa - Nasr city" ,
                    imageurl = "3.jpg" , departmentid = 1 , courseid = 3},
                new Instructor(){id =4 , Name = "nada sadek" , address = "Albahr al aazam" ,
                    imageurl = "4.jpg" , departmentid = 2 , courseid = 4},
                new Instructor(){id =5 , Name = "mahmoud mohamed" , address = "Elgamalia" ,
                    imageurl = "5.jpg" , departmentid = 2 , courseid = 5},
                new Instructor(){id =6 , Name = "yasmeen nael" , address = "Sedi_Beshr Alex" ,
                    imageurl = "6.jpg" , departmentid = 2 , courseid = 6},
                new Instructor(){id =7 , Name = "Ali Elgayar" , address = "Albahr al aazam" ,
                    imageurl = "7.jpg" , departmentid = 3 , courseid = 7},
                new Instructor(){id =8 , Name = "khaled hanafy" , address = "Sedi_Beshr Alex" ,
                    imageurl = "8.jpg" , departmentid = 3 , courseid = 8},
                new Instructor(){id =9 , Name = "mohamed nassem" , address = "Albahr al aazam" ,
                    imageurl = "9.jpg" , departmentid = 3 , courseid = 9},


            };

            modelBuilder.Entity<Instructor>().HasData(instructors);

            List<Trainee> trainees = new List<Trainee>() {

                new Trainee(){id = 1 , Name = "adel hamdy " , imageurl = "10.jpg" ,
                address = "talkha" , grade = 4.50d, departmentid = 1 },
                 new Trainee(){id = 2 , Name = "hussien kamel " , imageurl = "11.jpg" ,
                address = "talkha" , grade = 4.10d , departmentid = 1 },
                new Trainee(){id = 3 , Name = "tarek mohamed " , imageurl = "12.jpg" ,
                address = "talkha" , grade = 2.3d , departmentid = 1 },
                new Trainee(){id = 4 , Name = "omar nasif " , imageurl = "13.jpg" ,
                address = "talkha" , grade = 2.5d , departmentid = 2 },
                new Trainee(){id = 5 , Name = "layla nazmy " , imageurl = "14.jpg" ,
                address = "talkha" , grade = 1.3d , departmentid = 2 },
                new Trainee(){id = 6 , Name = "kadry mohamed " , imageurl = "15.jpg" ,
                address = "talkha" , grade = 3.6d , departmentid = 3 },
                new Trainee(){id = 7 , Name = "adel tarek " , imageurl = "16.jpg" ,
                address = "talkha" , grade = 4.7d , departmentid = 3 },
                new Trainee(){id = 8 , Name = "dena tawakol " , imageurl = "17.jpg" ,
                address = "talkha" , grade = 4.9d , departmentid = 3 },
            };

            modelBuilder.Entity<Trainee>().HasData(trainees);


            List<CourseResult> CourseResults = new List<CourseResult>() {
                new CourseResult() {id = 1 , degree = 20 , courseid = 1 , traineeid = 1  } ,
                new CourseResult() {id = 2 , degree = 59 , courseid = 1 , traineeid = 2  },
                new CourseResult() {id = 3 , degree = 44 , courseid = 1 , traineeid = 3  },
               new CourseResult() {id = 4, degree = 20 , courseid = 2 , traineeid = 1  } ,
                new CourseResult() {id = 5 , degree = 25 , courseid = 2 , traineeid = 2  },
                new CourseResult() {id = 6 , degree = 39 , courseid = 2 , traineeid = 3  },
                new CourseResult() {id = 7 , degree = 70 , courseid = 3 , traineeid = 1  } ,
                new CourseResult() {id = 8 , degree = 30 , courseid = 3 , traineeid = 2  },
                new CourseResult() {id = 9 , degree = 60 , courseid = 3 , traineeid = 3  },
                new CourseResult() {id = 10 , degree = 20 , courseid = 4 , traineeid = 4  } ,
                new CourseResult() {id = 11 , degree = 45 , courseid = 4 , traineeid = 5  },
                new CourseResult() {id = 12 , degree = 35 , courseid = 5 , traineeid = 4  },
                new CourseResult() {id = 13 , degree = 20 , courseid = 5 , traineeid = 5  },
                new CourseResult() {id = 14 , degree = 76 , courseid = 6 , traineeid = 4  },
                new CourseResult() {id = 15 , degree = 45 , courseid = 6 , traineeid = 5  },
                new CourseResult() {id = 16 , degree = 20 , courseid = 7 , traineeid = 6  } ,
                new CourseResult() {id = 17 , degree = 59 , courseid = 7 , traineeid = 7  },
                new CourseResult() {id = 18 , degree = 44 , courseid = 7 , traineeid = 8  },
               new CourseResult() {id = 19, degree = 20 , courseid = 8 , traineeid = 6} ,
                new CourseResult() {id = 20 , degree = 25 , courseid = 8 , traineeid = 7  },
                new CourseResult() {id = 21 , degree = 39 , courseid = 8 , traineeid = 8  },
                new CourseResult() {id = 22 , degree = 70 , courseid = 9 , traineeid = 6  } ,
                new CourseResult() {id = 23 , degree = 30 , courseid = 9 , traineeid = 7  },
                new CourseResult() {id = 24 , degree = 60 , courseid = 9 , traineeid = 8  },
            };

            modelBuilder.Entity<CourseResult>().HasData(CourseResults);


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Trainee> Trainees { get; set; } 
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseResult>  courseResults { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }


        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries())
            {
                var entity = entry.Entity; 

                if( entry.State == EntityState.Deleted && entity is Isoftdelete )
                {
                    entry.State = EntityState.Unchanged;
                    entity.GetType().GetProperty("Isdeleted").SetValue(entity, true); 
                }
            }

            return base.SaveChanges();
        }



    }
}
