using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ChatApp.Models;
using ChatApp.Services;

namespace ChatApp.ViewModels
{
    public partial class DetailViewModel : ViewModelBase
    {
        private readonly IMessageService _messageService;
        private User _currentUser;

        [ObservableProperty]
        private ObservableCollection<Message> _messages;

        // Свойство для привязки поля ввода нового сообщения
        [ObservableProperty]
        private string _newMessageText;

        public DetailViewModel(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public override async Task InitializeAsync(object parameter)
        {
            // В параметре ожидаем объект User, по которому перешли из HomeViewModel
            if (parameter is User user)
            {
                _currentUser = user;
                // Метод GetMessages должен быть обновлён для получения сообщений по конкретному пользователю
                Messages = new ObservableCollection<Message>(_messageService.GetMessages(_currentUser));
            }
            await base.InitializeAsync(parameter);
        }

        // Команда для кнопки отправки
        [RelayCommand]
        private void SendMessage()
        {
            if (string.IsNullOrWhiteSpace(NewMessageText))
                return;

            // Логика отправки сообщения через сервис
            // _messageService.SendMessage(_currentUser, NewMessageText);
            // TODO: Реализовать отправку

            // После отправки очищаем поле ввода
            NewMessageText = string.Empty;
        }
    }
}