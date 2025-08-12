using IotDashboardApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace IotDashboardApplication
{
    public class IotContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Data> Datas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data>().HasData(GenerateFakeData());
        }

        private IEnumerable<Data> GenerateFakeData()
        {
            for (int i = 0; i < 100; i++) 
            {
                DateTime date = new DateTime(2025, 8, 12, 11, 0, 0);
                date = date.AddMinutes(i);
                yield return new Data
                {
                    Id = i + 1,
                    Date = date,
                    Temperature = 22 + 0.1 * i,
                    Humidity = 50 + 0.1 * i,
                };
            }
        }
    }
}
