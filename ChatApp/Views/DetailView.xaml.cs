using ChatApp.ViewModels;

namespace ChatApp.Views
{
    public partial class DetailView : ContentPage
    {
        public DetailView(DetailViewModel viewModel)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = viewModel;
        }
    }
}