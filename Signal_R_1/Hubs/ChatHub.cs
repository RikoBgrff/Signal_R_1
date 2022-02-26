using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace Signal_R_1.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            var connectionId = Context.ConnectionId;
            Clients.All.SendAsync("OnConnected", connectionId);
            return base.OnConnectedAsync();
        }
        public async Task SendMessage(string message)
        {
            await Clients.Others.SendAsync("RecieveMessage", message);
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
