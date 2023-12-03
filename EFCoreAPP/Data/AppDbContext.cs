using Microsoft.EntityFrameworkCore;

namespace EFCoreAPP.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
    }
}
