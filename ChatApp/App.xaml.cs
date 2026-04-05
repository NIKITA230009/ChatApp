using ChatApp.ViewModels;
using ChatApp.Views;

namespace ChatApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var homeview = MauiProgram.ServiceProvider.GetRequiredService<HomeView>();

		MainPage = new NavigationPage(homeview);
	}
}