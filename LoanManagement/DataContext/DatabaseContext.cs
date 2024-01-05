using Microsoft.EntityFrameworkCore;

namespace LoanManagement.DataContext
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
               : base(options)
        {
        }
    }
}
