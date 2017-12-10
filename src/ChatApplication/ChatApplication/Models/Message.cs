using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace ChatApplication.Models
{
    public class Message : BindableBase
    {
        private string _username;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        private string _text;

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        private DateTime _messageDateTime;

        public DateTime MessageDateTime
        {
            get => _messageDateTime;
            set => SetProperty(ref _messageDateTime, value);
        }

        private bool _isIncoming;

        public bool IsIncoming
        {
            get => _isIncoming;
            set => SetProperty(ref _isIncoming, value);
        }
    }
}
