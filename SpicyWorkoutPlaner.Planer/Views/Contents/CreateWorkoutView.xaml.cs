using SpicyWorkoutPlaner.Planer.ViewModels.Contents;

namespace SpicyWorkoutPlaner.Planer;

public partial class CreateWorkoutView : ContentView
{
	public CreateWorkoutView(CreateWorkoutViewViewModel createWorkoutViewViewModel)
	{
		InitializeComponent();

		BindingContext = createWorkoutViewViewModel;
	}

	public void RegisterItemCreateEvent(EventHandler handler)
    {
		(BindingContext as CreateWorkoutViewViewModel).ItemCreated += handler;
	}
}