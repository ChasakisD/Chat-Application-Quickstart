using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ChatApplication.Models;

namespace ChatApplication.Interfaces
{
    public interface IChatService
    {
        Task Connect();
        Task Send(Message message, string roomName);
        Task JoinRoom(string roomName, string username);
        Task Disconnect();
        Task<IEnumerable<User>> GetUsersOnline();
        Task<User> GetUser(string deviceId);

        event EventHandler<Message> OnMessageReceived;
        event EventHandler<User> OnBanRecieved;
    }
}
