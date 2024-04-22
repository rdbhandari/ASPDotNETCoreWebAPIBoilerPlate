using ASPDotNETCoreWebApiBoilerPlate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNETCoreWebApiBoilerPlate.DAL
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<User> options) : base(options) { }
        public DbSet<User> users { get; set; }       
    }
}
