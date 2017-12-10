using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ChatApplication.Interfaces;
using ChatApplication.Models;
using Microsoft.AspNet.SignalR.Client;
using ModernHttpClient;
using Plugin.DeviceInfo;

namespace ChatApplication.Services
{
    public class ChatService : IChatService
    {
        private readonly HttpClient _httpClient = new HttpClient(new NativeMessageHandler());
        private HubConnection _connection;
        private IHubProxy _proxy;

        public event EventHandler<Message> OnMessageReceived;
        public event EventHandler<User> OnBanRecieved;

        public async Task Connect()
        {
            _connection = new HubConnection(Constants.AzureWebsiteUrl);
            _proxy = _connection.CreateHubProxy(Constants.ChatHubName);

            await _connection.Start();

            _proxy.On("GetMessage", (string name, string message) =>
            {
                OnMessageReceived?.Invoke(this, new Message
                {
                    Username = name,
                    Text = message
                });
            });
            _proxy.On("GetBan", (string deviceId, string reason) =>
            {
                OnBanRecieved?.Invoke(this, new User
                {
                    DeviceId = deviceId,
                    BlockedReason = reason
                });
            });
        }

        public async Task Disconnect()
        {
            try
            {
                await _proxy.Invoke("Disconnect");
                _connection.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task Send(Message message, string roomName)
        {
            await _proxy.Invoke("SendMessage", message.Username, message.Text, roomName);
        }

        public async Task JoinRoom(string roomName, string username)
        {
            await _proxy.Invoke("JoinRoom", roomName);
            await _proxy.Invoke("Connect", username, CrossDeviceInfo.Current.Id);
        }
        
        public Task<IEnumerable<User>> GetUsersOnline()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string deviceId)
        {
            throw new NotImplementedException();
        }
    }
}
