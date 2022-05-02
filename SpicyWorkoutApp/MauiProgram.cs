using SpicyWorkoutApp.Modules;
using SpicyWorkoutApp.Services;
using SpicyWorkoutPlaner.Core.Interfaces;
using SpicyWorkoutPlaner.Core.Services;
using SpicyWorkoutPlaner.Planer;
using SpicyWorkoutPlaner.Planer.ViewModels;
using SpicyWorkoutPlaner.Planer.ViewModels.Contents;
using SpicyWorkoutPlaner.Planer.Views;

namespace SpicyWorkoutApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Add Services to Services
		builder.Services.AddTransient<IRepository, Repository>();
		builder.Services.AddSingleton<INavigationService, NavigationService>();

		// Add Views to Services
		builder.Services.AddTransient<CreateWorkoutPage>();
		builder.Services.AddTransient<CreateWorkoutView>();

		// Add ViewModels to Services
		builder.Services.AddTransient<CreateWorkoutPageViewModel>();
		builder.Services.AddTransient<CreateWorkoutViewViewModel>();


		DatabaseModule.InitializeDatabase();

		return builder.Build();
	}
}
