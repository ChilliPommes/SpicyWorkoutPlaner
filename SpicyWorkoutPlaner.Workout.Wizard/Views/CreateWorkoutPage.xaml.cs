using SpicyWorkoutPlaner.Workout.Wizard.ViewModels;

namespace SpicyWorkoutPlaner.Workout.Wizard.Views;

public partial class CreateWorkoutPage : ContentPage
{
    public CreateWorkoutPage(CreateWorkoutPageViewModel createWorkoutPageViewModel)
    {
        InitializeComponent();

        BindingContext = createWorkoutPageViewModel;
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender == StaticCheckbox && StaticCheckbox.IsChecked == true)
        {
            FlexCheckbox.IsChecked = false;
        }

        if (sender == FlexCheckbox && FlexCheckbox.IsChecked == true)
        {
            StaticCheckbox.IsChecked = false;
        }
    }
}