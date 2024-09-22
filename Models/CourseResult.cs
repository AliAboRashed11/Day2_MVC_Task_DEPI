namespace Day2.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        public int CourseID { get; set; }
        public virtual Course Courses { get; set; }

        public int TraineeID { get; set; }
        public virtual Trainee Trainees { get; set; }
    }
}
