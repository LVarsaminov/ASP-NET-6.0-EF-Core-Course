using Microsoft.EntityFrameworkCore;

namespace StudentsMinimalAPI
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Student> Students => Set<Student>();
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}
