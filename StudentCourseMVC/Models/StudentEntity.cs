namespace StudentCourseMVC.Models
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CourseTitle { get; set; } = string.Empty;

        public double TotalMarks { get; set; }
        public StatusEnum Status
        {
            get
            {
                if (TotalMarks < 50)
                {
                    return StatusEnum.NeedsImprovement;
                }
                else if (TotalMarks <= 80) 
                {
                    return StatusEnum.Good;
                }
                else 
                {
                    return StatusEnum.Excellent;
                }
            }
        }

        public enum StatusEnum
        {
            Good,
            Excellent,
            NeedsImprovement
        }

    }
}
