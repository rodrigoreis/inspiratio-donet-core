using Inspiratio.DotnetCore.Web.Services;
using Microsoft.AspNetCore.SignalR;

namespace Inspiratio.DotnetCore.Web.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ISpellingCheckService _spellingCheckService;

        public ChatHub(ISpellingCheckService spellingCheckService)
        {
            _spellingCheckService = spellingCheckService;
        }

        public void Send(string name, string message)
        {
            Clients.All.SendAsync("broadcastMessage", name, _spellingCheckService.GetFriendlyMessage(message));
        }
    }
}
