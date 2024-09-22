namespace Day2.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Imageurl { get; set; }
        public string Address { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public int CourseID { get; set; }

        public virtual Course Course { get; set; }
    }
}
