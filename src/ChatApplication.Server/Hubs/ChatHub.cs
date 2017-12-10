using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatApplication.Server.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string username, string message, string groupname)
        {
            Clients.Group(groupname).GetMessage(username, message);
        }

        public Task JoinGroup(string name)
        {
            return Groups.Add(Context.ConnectionId, name);
        }

        public Task LeaveGroup(string name)
        {
            return Groups.Remove(Context.ConnectionId, name);
        }
    }
}