using LoanManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanManagement.DataContext
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
               : base(options)
        {
          
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LoanMaster> LoanMasters { get; set; }
        public DbSet<SavingMaster> SavingMasters { get; set; }
        public DbSet<CompanySetUP> CompanyMasters { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Guarantor> Guarantors { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Nominee> Nomines { get; set; }
        public DbSet<PermanentAddress> PermanentAddresses { get; set; }
        public DbSet<PresentAddress> PresentAddresses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SavingDetails> SavingDetails { get; set; }
        public DbSet<UserList> UserList { get; set; }
        public DbSet<Permission> Permissions { get; set; }

    }
}
