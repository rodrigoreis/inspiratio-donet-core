using Microsoft.AspNetCore.SignalR;

namespace Inspiratio.DotnetCore.Web.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.SendAsync("broadcastMessage", name, message);
        }
    }
}
