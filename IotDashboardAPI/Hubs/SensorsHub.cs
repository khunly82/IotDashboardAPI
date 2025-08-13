using Microsoft.AspNetCore.SignalR;

namespace IotDashboardAPI.Hubs
{
    public class SensorsHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            Console.WriteLine("Un client s'est connecté :D");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception) {
            Console.WriteLine("Un client s'est déconnecté D:");
            await base.OnDisconnectedAsync(exception);
        }
    }
}
