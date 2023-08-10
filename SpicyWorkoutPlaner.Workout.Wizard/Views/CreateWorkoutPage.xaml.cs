using SpicyWorkoutPlaner.Core.Services;
using SpicyWorkoutPlaner.Core.Static;
using SpicyWorkoutPlaner.Workout.Wizard.ViewModels;

namespace SpicyWorkoutPlaner.Workout.Wizard.Views;

public partial class CreateWorkoutPage : ContentPage
{
    public CreateWorkoutPage()
    {
        InitializeComponent();

        var test = GlobalServiceProvider.Instance.GetService(typeof(CreateWorkoutPageViewModel));

        BindingContext = test;
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