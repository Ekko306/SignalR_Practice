using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;


namespace SignalRChat.Hubs
{
    public class ChatHub : Hub  // HUB类 管理连接 组和消息     中心所有发送消息
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
