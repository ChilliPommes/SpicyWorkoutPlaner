using SpicyWorkoutPlaner.Components.UI.GranularComponents;
using System.Runtime.CompilerServices;

namespace SpicyWorkoutPlaner.Components.UI;

public partial class ProgressStepper : ContentView
{
    public static readonly BindableProperty StepperColorProperty =
        BindableProperty.Create("StepperColor", typeof(Color), typeof(ProgressStepper), Color.FromArgb("#00000000"));

    public static readonly BindableProperty StepperPositionColorProperty =
        BindableProperty.Create("StepperPositionColor", typeof(Color), typeof(ProgressStepper), Color.FromArgb("#00111111"));

    public static readonly BindableProperty StepperCountProperty =
        BindableProperty.Create("StepperCount", typeof(int), typeof(ProgressStepper), 1);

    public static readonly BindableProperty StepperPositionProperty =
        BindableProperty.Create("StepperPosition", typeof(int), typeof(ProgressStepper), 0);

    private BoxView[] _stepperDots;

    public ProgressStepper()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Stores the color of all stepper dots
    /// </summary>
    public Color StepperColor
    {
        get => (Color)GetValue(StepperColorProperty);
        set => SetValue(StepperColorProperty, value);
    }

    /// <summary>
    /// Stores the color of stepper position which is the actual one
    /// </summary>
    public Color StepperPositionColor
    {
        get => (Color)GetValue(StepperPositionColorProperty);
        set => SetValue(StepperPositionColorProperty, value);
    }

    /// <summary>
    /// Stores the amount of stepper dots of the component
    /// </summary>
    public int StepperCount
    {
        get => (int)GetValue(StepperCountProperty);
        set => SetValue(StepperCountProperty, value);
    }

    /// <summary>
    /// Stores the actual position of the stepper in the whole process
    /// </summary>
    public int StepperPosition
    {
        get => (int)GetValue(StepperPositionProperty);
        set => SetValue(StepperPositionProperty, value);
    }

    /// <summary>
    /// Property changed event handler
    /// </summary>
    /// <param name="propertyName"></param>
    protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        switch (propertyName)
        {
            case nameof(StepperCount):

                HorizontalStackLayout hsl = new HorizontalStackLayout();

                for (int i = 0; i < StepperCount; i++)
                {
                    var step = new StepperDot();

                    hsl.Add(step);
                }

                hsl.Add(new BoxView { BackgroundColor = Colors.Black });

                StepperBox.Content = hsl;

                break;

            case nameof(StepperPosition):
                break;

            case nameof(StepperColor):
                break;

            case nameof(StepperPositionColor):
                break;
        }
    }
}