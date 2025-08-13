namespace IotDashboardAPI.Hubs.Interfaces
{
    public interface ISensorsNotifier
    {
        Task NotifyAsync(int id, DateTime date, double temperature, double humidity);
        Task NotifyEmergencyAsync(string room);
    }
}
