using Microsoft.EntityFrameworkCore;

namespace IotDashboardApplication.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public byte[] Password { get; set; } = null!;
        public Guid Salt { get; set; }
    }
}
