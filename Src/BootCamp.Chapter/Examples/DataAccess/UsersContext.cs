using Microsoft.EntityFrameworkCore;

namespace BootCamp.Chapter.Examples.DataAccess
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
