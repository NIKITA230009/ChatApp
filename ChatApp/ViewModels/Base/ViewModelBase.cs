using CommunityToolkit.Mvvm.ComponentModel;

namespace ChatApp.ViewModels
{
    public class ViewModelBase : ObservableObject
    {
        public virtual Task InitializeAsync(object parametr)
        {
            return Task.CompletedTask;
        }
    }
}