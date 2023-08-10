using Microsoft.Extensions.DependencyInjection.Extensions;
using SpicyWorkoutApp.Services;
using SpicyWorkoutPlaner.Core.Interfaces;
using SpicyWorkoutPlaner.Core.Static;
using SpicyWorkoutPlaner.Database;
using SpicyWorkoutPlaner.Workout.Wizard;

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

		// Add Views to Services

		// Add ViewModels to Services

		builder.Services.AddSingleton<INavigationService, NavigationService>();

		builder.Services.InitializeWizardModule();
		builder.Services.InitializeDatabaseModule();

		SetHandler();

		RegisterRouting();

		GlobalServiceProvider.Instance = builder.Services.BuildServiceProvider();

		return builder.Build();
	}

	public static void SetHandler()
    {
		//Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("EntryUnderline", (h, v) =>
		//{
		//	h.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Black.ToPlatform());
		//});

		//Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("EditorUnderline", (h, v) =>
		//{
		//	h.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Black.ToPlatform());
		//});
	}

	private static void RegisterRouting()
	{
	}
}
