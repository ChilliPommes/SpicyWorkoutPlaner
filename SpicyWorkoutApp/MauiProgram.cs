using SpicyWorkoutApp.Services;
using SpicyWorkoutPlaner.Core.Interfaces;
using SpicyWorkoutPlaner.Database;
using SpicyWorkoutPlaner.Planer;
using SpicyWorkoutPlaner.Planer.ViewModels;
using SpicyWorkoutPlaner.Planer.ViewModels.Contents;
using SpicyWorkoutPlaner.Planer.ViewModels.Workouts;
using SpicyWorkoutPlaner.Planer.Views;
using SpicyWorkoutPlaner.Planer.Views.Contents;
using SpicyWorkoutPlaner.Planer.Views.Workouts;
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

        // Add Services to Services
        builder.Services.AddSingleton<INavigationService, NavigationService>();

		// Add Views to Services

		// Add ViewModels to Services

		builder.Services.InitializeWizardModule();
		builder.Services.InitializeDatabaseModule();

		SetHandler();

		RegisterRouting();

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
