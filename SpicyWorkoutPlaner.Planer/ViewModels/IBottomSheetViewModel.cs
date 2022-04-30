namespace SpicyWorkoutPlaner.Planer.ViewModels
{
    public interface IBottomSheetViewModel
    {
        Guid Id { get; }

        bool UseSwipeDownToClose { get; }

        bool UseClickOutsideToClose { get; }

        Color BackGroundColor { get; }
    }
}
