using ChatApplication.Models;
using Xamarin.Forms;

namespace ChatApplication.Cells
{
    public class MessageDataTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate _incomingDataTemplate;
        private readonly DataTemplate _outgoingDataTemplate;

        public MessageDataTemplateSelector()
        {
            _incomingDataTemplate = new DataTemplate(typeof(IncomingMessageViewCell));
            _outgoingDataTemplate = new DataTemplate(typeof(OutgoingMessageViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (!(item is Message messageVm))
                return null;

            return messageVm.IsIncoming ? _incomingDataTemplate : _outgoingDataTemplate;
        }
    }
}
