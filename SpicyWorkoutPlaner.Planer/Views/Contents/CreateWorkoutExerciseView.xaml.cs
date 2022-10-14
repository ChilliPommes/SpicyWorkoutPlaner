using SpicyWorkoutPlaner.Planer.ViewModels.Contents;

namespace SpicyWorkoutPlaner.Planer.Views.Contents;

public partial class CreateWorkoutExerciseView : ContentView
{
	public CreateWorkoutExerciseView(CreateWorkoutExerciseViewViewModel createWorkoutExerciseViewViewModel)
	{
		InitializeComponent();

        BindingContext = createWorkoutExerciseViewViewModel;

        RegisterKeyBoardHandling();
    }

    public void RegisterItemCreateEvent(EventHandler handler)
    {
        //(BindingContext as CreateWorkoutViewViewModel).ItemCreated += handler;
    }

    private void RegisterKeyBoardHandling()
    {
        NameEntry.ReturnType = ReturnType.Done;
        NameEntry.ReturnCommand = new Command(() =>
        {
            DescriptionEditor.Focus();
        });

        DescriptionEditor.Keyboard = Keyboard.Text;
    }
}