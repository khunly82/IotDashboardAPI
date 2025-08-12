using System.ComponentModel.DataAnnotations;

namespace IotDashboardAPI.Dto
{
    public class AddDataDto
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [Range(-100, 100)]
        public double Temperature { get; set; }
        [Required]
        [Range(0, 100)]
        public double Humidity { get; set; }
    }
}
