using Xamarin.Forms;

namespace ChatApplication.Views
{
    public partial class UsersOnlinePage
    {
        public UsersOnlinePage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (sender is ListView list) list.SelectedItem = null;
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (sender is ListView list) list.SelectedItem = null;
        }
    }
}
