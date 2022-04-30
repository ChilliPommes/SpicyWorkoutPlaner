namespace SpicyWorkoutPlaner.Planer.Controls.BaseControls;

public partial class Card : ContentView
{
	public static BindableProperty CornerRadiusProperty = BoxView.CornerRadiusProperty;

	public Card()
	{
		InitializeComponent();
	}

	public CornerRadius CornerRadius
    {
		get => (CornerRadius)GetValue(CornerRadiusProperty);
		set => SetValue(CornerRadiusProperty, value);
    }
}