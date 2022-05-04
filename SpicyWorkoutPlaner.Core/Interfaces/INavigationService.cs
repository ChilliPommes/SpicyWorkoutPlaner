namespace SpicyWorkoutPlaner.Core.Interfaces
{
    public interface INavigationService
    {
        Task NavigateTo<T>(T page, bool isPopUp);

        Task NavigateBack(bool isPopup = false);
    }
}
