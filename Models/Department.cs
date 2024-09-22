namespace Day2.Models
{
    public class Department
    {

            public int Id { get; set; }
            public string name { get; set; }
            public string manager { get; set; }

            public virtual ICollection<Instructor> Instructors { get; set; }

            public virtual ICollection<Trainee> Students { get; set; }
            public virtual ICollection<Course> Courses { get; set; }

        }
    }

