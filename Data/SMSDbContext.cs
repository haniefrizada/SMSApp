using Microsoft.EntityFrameworkCore;
using SMSApp.Models.Domain;

namespace SMSApp.Data
{
    //inheritance
    //SMSDbContext inherits from the base class DbContext
    public class SMSDbContext : DbContext //comes from entity framework core
    {
        public SMSDbContext(DbContextOptions options) : base(options) //Passing the options back to the base class
        {
        }

        //Properties to access the tables in the database
        public DbSet<Student> Students { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Todo> Todos { get; set; }
    }
}