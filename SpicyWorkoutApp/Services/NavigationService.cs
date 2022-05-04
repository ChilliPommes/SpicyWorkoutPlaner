using SpicyWorkoutPlaner.Core.Interfaces;

namespace SpicyWorkoutApp.Services
{
    public sealed class NavigationService : INavigationService
    {
        private readonly IServiceProvider serviceProvider;
        private readonly INavigation navigation;

        public NavigationService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            navigation = Application.Current.MainPage.Navigation;
        }

        public async Task NavigateTo<T>(T item, bool isPopup = false)
        {
            if (item is Page page)
            {
                if (isPopup)
                {
                    await navigation.PushModalAsync(page, false).ConfigureAwait(true);
                }
                else
                {
                    await navigation.PushAsync(page).ConfigureAwait(true);
                }
            }
        }

        public async Task NavigateBack(bool isPopup = false)
        {
            if (isPopup)
            {
                await navigation.PopModalAsync(false).ConfigureAwait(true);
            }
            else
            {
                await navigation.PopAsync().ConfigureAwait(true);
            }
        }
    }
}
