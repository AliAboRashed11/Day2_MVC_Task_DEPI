namespace Day2.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Imageurl { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; }
    }
}
