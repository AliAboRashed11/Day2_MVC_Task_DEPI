namespace Day2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mindegree { get; set; }
        public int Grade { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
