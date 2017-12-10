using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using ChatApplication.Interfaces;
using Prism.Navigation;

namespace ChatApplication.ViewModels
{
	public class JoinChatPageViewModel : ViewModelBase
	{
	    private readonly IChatService _chatService;

        public JoinChatPageViewModel(
            IChatService chatService,
            INavigationService navigationService)
            :base(navigationService)
        {
            _chatService = chatService;
        }
	}
}
