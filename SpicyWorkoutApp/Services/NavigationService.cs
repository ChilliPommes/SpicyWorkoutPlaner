using SpicyWorkoutPlaner.Core.Interfaces;

namespace SpicyWorkoutApp.Services
{
    internal class NavigationService : INavigationService
    {
        public NavigationService() { }

        public async Task NavigateTo(string route)
        {
            await Shell.Current.GoToAsync(route);
        }
    }
}
