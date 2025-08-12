using IotDashboardApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace IotDashboardApplication
{
    public class IotContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Data> Datas { get; set; }
    }
}
