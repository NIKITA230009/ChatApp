using ChatApp.Services;
using ChatApp.ViewModels;
using ChatApp.Views;

namespace ChatApp;

public static class MauiProgram
{
	public static IServiceProvider ServiceProvider { get; private set; }
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Metropolis-Black.otf", "Metropolis Black");
				fonts.AddFont("Metropolis-Light.otf", "Metropolis Light");
				fonts.AddFont("Metropolis-Medium.otf", "Metropolis Medium");
				fonts.AddFont("Metropolis-Regular.otf", "Metropolis Regular");
				fonts.AddFont("Metropolis-Regular.otf", "Metropolis Regular");
				fonts.AddFont("MaterialIcons-Regular.ttf", "Material Icons");
			});

		builder.Services.AddSingleton<IMessageService, MessageService>();
		builder.Services.AddSingleton<INavigationService, NavigationService>();

		builder.Services.AddTransient<HomeViewModel>();
		builder.Services.AddTransient<DetailViewModel>();

		builder.Services.AddTransient<HomeView>();
		builder.Services.AddTransient<DetailView>();

		var app = builder.Build();
		ServiceProvider = app.Services;

		return app;
	}
}
