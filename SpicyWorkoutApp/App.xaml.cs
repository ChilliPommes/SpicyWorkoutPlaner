using Microsoft.Maui.Handlers;
using SpicyWorkoutPlaner.Core.Static;

namespace SpicyWorkoutApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
    }

    private void OnWorkaround(IWindowHandler arg1, IWindow arg2, Action<IElementHandler, IElement> arg3)
    {
        WindowHandler.MapContent(arg1, arg2);
    }
}
