using FriendStorage.DataAccess;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;
using System;
using System.Collections.ObjectModel;

namespace FriendStorage.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        public NavigationViewModel(INavigationDataProvider dataProvider)
        {
            Friends = new ObservableCollection<Friend>();
            _dataProvider = dataProvider;
        }

        public void Load()
        {
            foreach (var friend in _dataProvider.GetAllFriends())
            {
                Friends.Add(friend);
            }
        }

        public ObservableCollection<Friend> Friends { get; private set; }

        private INavigationDataProvider _dataProvider;
    }
}
