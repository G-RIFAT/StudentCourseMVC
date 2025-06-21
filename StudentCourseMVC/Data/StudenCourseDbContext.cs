using Microsoft.EntityFrameworkCore;

namespace StudentCourseMVC.Data
{
    public class StudenCourseDbContext : DbContext
    {

        public StudenCourseDbContext(DbContextOptions<StudenCourseDbContext> options) : base(options)
        {
        }
        public DbSet<StudentCourseMVC.Models.StudentEntity> Students { get; set; }

    }
}
