using SpicyWorkoutPlaner.Planer.ViewModels.Contents;

namespace SpicyWorkoutPlaner.Planer;

public partial class CreateWorkoutView : ContentView
{
    public CreateWorkoutView(CreateWorkoutViewViewModel createWorkoutViewViewModel)
    {
        InitializeComponent();

        BindingContext = createWorkoutViewViewModel;

        RegisterKeyBoardHandling();
    }

    public void RegisterItemCreateEvent(EventHandler handler)
    {
        (BindingContext as CreateWorkoutViewViewModel).ItemCreated += handler;
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