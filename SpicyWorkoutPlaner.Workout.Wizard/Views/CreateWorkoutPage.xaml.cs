using SpicyWorkoutPlaner.Workout.Wizard.ViewModels;

namespace SpicyWorkoutPlaner.Workout.Wizard.Views;

public partial class CreateWorkoutPage : ContentPage
{
    public CreateWorkoutPage(CreateWorkoutPageViewModel createWorkoutPageViewModel)
    {
        InitializeComponent();

        BindingContext = createWorkoutPageViewModel;
    }
}