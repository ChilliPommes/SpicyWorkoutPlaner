using SpicyWorkoutPlaner.Planer.ViewModels;

namespace SpicyWorkoutPlaner.Planer.Controls;

public partial class BottomSheetPage : ContentPage
{
	private IBottomSheetViewModel? viewModel;

	private bool animationIsRunning;

	public static BindableProperty SheetContentProperty = BindableProperty.Create(
		nameof(SheetContent),
		typeof(View),
		typeof(BottomSheetPage),
		defaultValue: default(View),
		defaultBindingMode: BindingMode.TwoWay);

	public View SheetContent
    {
		get => (View)GetValue(SheetContentProperty);
		set
        {
			SetValue(SheetContentProperty, value);
			OnPropertyChanged();
        }
    }

	public BottomSheetPage()
	{
		InitializeComponent();
		animationIsRunning = true;
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();

		if (BindingContext is null)
        {
			return;
        }

		if (BindingContext is not IBottomSheetViewModel bottomSheetViewModel)
        {
			throw new ArgumentException($"{nameof(BottomSheetPage)}: {nameof(BindingContext)} has to be type of {nameof(IBottomSheetViewModel)}");
        }

		this.viewModel = bottomSheetViewModel;
    }

	private async void SwipeGestureRecognizer_OnSwiped(object sender, SwipedEventArgs e)
    {
		if (animationIsRunning)
        {
			return;
        }

		if (viewModel?.UseSwipeDownToClose == true)
        {
			await Close();
        }
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
		if (animationIsRunning)
        {
			return;
        }

		if (viewModel?.UseClickOutsideToClose == true)
        {
			await Close();
        }
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
		ShowContent().ConfigureAwait(true);
    }

    private async Task ShowContent()
    {
		animationIsRunning = true;
		await Task.WhenAll(
			Backdrop.FadeTo(0.4, 250, Easing.Linear),
			BottomSheetCard.TranslateTo(0, 0, 250, Easing.Linear));

		animationIsRunning = false;
    }

	private async Task DismissContent()
    {
		animationIsRunning = true;
		await Task.WhenAll(
			Backdrop.FadeTo(0, 250, Easing.Linear),
			BottomSheetCard.TranslateTo(0, this.Height, 250, Easing.Linear));

		animationIsRunning = false;
	}

	private async Task Close()
    {
		if (viewModel is null)
        {
			return;
        }

		await DismissContent().ConfigureAwait(true);
		await Application.Current.MainPage.Navigation.PopModalAsync(false).ConfigureAwait(true);
    }
}