namespace SpicyWorkoutApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			await Sheet.OpenSheet();
		}
		catch (Exception ex)
		{
			//ex.Log();
		}
	}
}

