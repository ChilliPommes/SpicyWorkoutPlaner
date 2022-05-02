using SpicyWorkoutPlaner.Core.Interfaces;
using SpicyWorkoutPlaner.Core.ViewModels;
using SpicyWorkoutPlaner.Planer.Controls;
using System.Windows.Input;

namespace SpicyWorkoutPlaner.Planer.ViewModels
{
    public class CreateWorkoutPageViewModel : BaseViewModel
    {
        private readonly INavigationService navigationService;
        private readonly IServiceProvider serviceProvider;

        public CreateWorkoutPageViewModel(
            INavigationService navigationService,
            IServiceProvider serviceProvider)
        {
            this.navigationService = navigationService;
            this.serviceProvider = serviceProvider;
        }

        public ICommand AddCommand => new Command(async () =>
        {
            var view = serviceProvider.GetService<CreateWorkoutView>();

            if (view is not null)
            {
                await navigationService.NavigateTo(new BottomSheetPage()
                {
                    SheetContent = view
                }, true);
            }
        });
    }
}
