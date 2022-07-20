using SpicyWorkoutPlaner.Planer.ViewModels.ListItems;
using SpicyWorkoutPlaner.Planer.ViewModels.Workouts;

namespace SpicyWorkoutPlaner.Planer.Views.Workouts;

[QueryProperty(nameof(WorkoutListItemViewModel), "WorkoutListItemViewModel")]
public partial class WorkoutDetailPage : ContentPage
{
	private WorkoutListItemViewModel workoutListItemViewModel;

	public WorkoutDetailPage()
	{
        InitializeComponent();
    }

    public WorkoutDetailPage(WorkoutDetailPageViewModel workoutDetailPageViewModel)
	{
		InitializeComponent();

		BindingContext = workoutDetailPageViewModel;
	}

	public WorkoutListItemViewModel WorkoutListItemViewModel
	{
		get => workoutListItemViewModel;
		set
		{
			workoutListItemViewModel = value;
			(BindingContext as WorkoutDetailPageViewModel).SetItem(workoutListItemViewModel);
        }
    }
}