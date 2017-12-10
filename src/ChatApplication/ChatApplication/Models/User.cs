using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace ChatApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string ConnectionId { get; set; }
        public string DeviceId { get; set; }
        public bool Active { get; set; }
        public bool Blocked { get; set; }
        public string BlockedReason { get; set; }
    }
}
