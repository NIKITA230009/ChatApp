using ChatApp.Models;
using ChatApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ChatApp.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {

        INavigationService _navigationService;
        IMessageService _messageService;

       

        [ObservableProperty]
        private ObservableCollection<User> _users;

        [ObservableProperty]
        public ObservableCollection<Message> _recentChat;

        public HomeViewModel(INavigationService navigationService, IMessageService messageService)
        {
            _navigationService = navigationService;
            _messageService = messageService;
            LoadData();
        }


        void LoadData()
        {
            Users = new ObservableCollection<User>(_messageService.GetUsers());
            RecentChat = new ObservableCollection<Message>(_messageService.GetChats());
        }

        [RelayCommand]
        async Task OnNavigate(object parameter)
        {
            if (parameter is Message message && message.Sender != null)
            {
                await _navigationService.NavigateToAsync<DetailViewModel>(message.Sender);
            }
        }
    }
}