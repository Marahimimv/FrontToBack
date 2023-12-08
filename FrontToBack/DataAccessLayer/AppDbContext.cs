using Microsoft.EntityFrameworkCore;

namespace FrontToBack.DataAccessLayer
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        {

        }
    }
}
