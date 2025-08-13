using IotDashboardAPI.Hubs.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace IotDashboardAPI.Hubs
{
    public class SensorsNotifier(IHubContext<SensorsHub> hub) : ISensorsNotifier
    {
        public Task NotifyAsync(int id, DateTime date, double temperature, double humidity)
        {
            var payload = new {
                Id = id,
                Date = date.ToLocalTime(),
                Temperature = temperature,
                Humidity = humidity
            };
            return hub.Clients.All.SendAsync("ReceiveSensorData", payload);
        }

        public Task NotifyEmergencyAsync(string room)
        {
            return hub.Clients.All.SendAsync("ReceiveEmergency", room);
        }
    }
}
