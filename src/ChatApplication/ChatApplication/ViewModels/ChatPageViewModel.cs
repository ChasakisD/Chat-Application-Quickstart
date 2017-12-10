using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace ChatApplication.ViewModels
{
	public class ChatPageViewModel : ViewModelBase
	{
        public ChatPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
	}
}
