using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ChatSample
{
    public class ChatHub : Hub
    {
        public async Task SendMessageAsync(string sender, string message)
        {
            // Call the "ReceiveMessage" method on _all_ connected clients!
            await Clients.All.SendAsync("ReceiveMessage", sender, message);
        }
    }
}