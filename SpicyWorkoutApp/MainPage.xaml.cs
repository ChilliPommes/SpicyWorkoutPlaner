using SpicyWorkoutPlaner.Planer.Controls;

namespace SpicyWorkoutApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Application.Current.MainPage.Navigation.PushModalAsync(new BottomSheetPage(), false).ConfigureAwait(true);
    }
}

