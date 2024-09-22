using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Day2.Models
{
    public class DBContextCourse : DbContext
    {


        public DBContextCourse():base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("server=ALI;database= Course; Integrated Security=true ; Encrypt=false");
                base.OnConfiguring(optionsBuilder);
            }
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Department> Departments { get; set; }
            public DbSet<Trainee> Trainees { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<CourseResult> CourseResults { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //Data Seeding 
                //Data Initializer
                //List<Department> departmentList = new List<Department>();
                //departmentList.Add(new Department { Name = "MIS" , Manager="Mohamed" });
                //departmentList.Add(new Department { Name = "CS", Manager = "Ahmed" });
                //departmentList.Add(new Department { Name = "IT", Manager = "Nader" });
                //departmentList.Add(new Department { Name = "IS", Manager = "Nada" });


                var departments = new List<Department>()
            {
            new Department {Id=1, name = "MIS",manager = "Mohamed" },
            new Department {Id=2, name = "CS", manager = "Ahmed" },
            new Department {Id=3, name = "IT", manager = "sara" },
            new Department {Id=4, name = "IS", manager = "ali" }
            };

                modelBuilder.Entity<Department>().HasData(departments);



                var courses = new List<Course>()
            {
            new Course {Id=1, Name = "C#", Grade= 100, Mindegree = 50, DepartmentID= 2},
            new Course {Id=2, Name = "Css", Grade= 100, Mindegree = 60, DepartmentID= 1},
            new Course {Id=3, Name = "Linq", Grade= 100, Mindegree = 50, DepartmentID= 2},
            new Course {Id=4, Name = "JS", Grade= 100, Mindegree = 70, DepartmentID= 3},
            new Course {Id=5, Name = "HTML", Grade= 100, Mindegree = 50, DepartmentID= 4},
            new Course {Id=6, Name = "Bootstrap", Grade= 100, Mindegree = 50, DepartmentID= 1}

            };
                modelBuilder.Entity<Course>().HasData(courses);

                var instructors = new List<Instructor>()
            {
            new Instructor {Id=1, Name = "Mohamed", Imageurl = "4.jpg" , Address="Mansoura" , DepartmentID = 1, CourseID = 1},
            new Instructor {Id = 2,  Name = "Yousef", Imageurl = "1.jpg" , Address="Mansoura" , DepartmentID = 2, CourseID = 3},
            new Instructor {Id = 3,  Name = "Nagey", Imageurl = "4.jpg" , Address="Tanta" , DepartmentID = 2, CourseID = 2},
            new Instructor {Id = 4,  Name = "Reham", Imageurl = "1.jpg" , Address="Mansoura" , DepartmentID = 3, CourseID = 1},
            new Instructor {Id = 5,  Name = "Mahmoud", Imageurl = "4.jpg" , Address="Mahala" , DepartmentID = 1, CourseID = 4}

            };
                modelBuilder.Entity<Instructor>().HasData(instructors);

                var trainees = new List<Trainee>()
            {
            new Trainee {Id = 1, Name = "Ahmed", Imageurl = "4.jpg" , Address="Mansoura" , Grade=80 , DepartmentID = 1},
            new Trainee {Id = 2, Name = "Mohamed", Imageurl = "1.jpg" , Address="Mansoura" , Grade=68 , DepartmentID = 2},
            new Trainee {Id = 3, Name = "Mahmoud", Imageurl = "4.jpg" , Address="Tanta" , Grade=92 , DepartmentID = 2},
            new Trainee {Id = 4, Name = "Yara", Imageurl = "1.jpg" , Address="Cairo" , Grade=75 , DepartmentID = 1},
            new Trainee {Id = 5,  Name = "Nadeen", Imageurl = "4.jpg" , Address="Mansoura" , Grade=90 , DepartmentID = 1},
            new Trainee {Id = 6, Name = "Nora", Imageurl = "1.jpg" , Address="Mahala" , Grade=80 , DepartmentID = 3},
            new Trainee {Id = 7,  Name = "Hend", Imageurl = "4.jpg" , Address="Mansoura" , Grade=88 , DepartmentID = 4}



            };
                modelBuilder.Entity<Trainee>().HasData(trainees);

                var courseResults = new List<CourseResult>()
            {
            new CourseResult {Id=1, Degree= 80 , CourseID= 1, TraineeID= 1  },
            new CourseResult {Id=2, Degree= 86 , CourseID= 2, TraineeID= 5  },
            new CourseResult {Id = 3,  Degree= 75 , CourseID= 3, TraineeID= 4  },
            new CourseResult {Id = 4,  Degree= 70 , CourseID= 2, TraineeID= 5  },
            new CourseResult {Id = 5, Degree= 92 , CourseID= 4, TraineeID= 3  },
            new CourseResult {Id = 6,  Degree= 87 , CourseID= 1, TraineeID= 2  }




            };
                modelBuilder.Entity<CourseResult>().HasData(courseResults);

                base.OnModelCreating(modelBuilder);
            }
        }
    }

