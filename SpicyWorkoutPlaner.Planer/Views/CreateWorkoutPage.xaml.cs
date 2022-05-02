using SpicyWorkoutPlaner.Planer.ViewModels;

namespace SpicyWorkoutPlaner.Planer.Views;

public partial class CreateWorkoutPage : ContentPage
{
	public CreateWorkoutPage(CreateWorkoutPageViewModel createWorkoutPageViewModel)
	{
		InitializeComponent();

		BindingContext = createWorkoutPageViewModel;
	}
}