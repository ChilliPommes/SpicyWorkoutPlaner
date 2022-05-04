using SpicyWorkoutPlaner.Core.Interfaces;
using SpicyWorkoutPlaner.Core.Resx;
using SpicyWorkoutPlaner.Core.Services;
using SpicyWorkoutPlaner.Core.ViewModels;
using SpicyWorkoutPlaner.Planer.Models;
using System.Windows.Input;

namespace SpicyWorkoutPlaner.Planer.ViewModels.Contents
{
    public class CreateWorkoutViewViewModel : BaseViewModel
    {
        private readonly INavigationService navigationService;
        private readonly IRepository repository;
        private string? name;
        private string? description;

        public CreateWorkoutViewViewModel(
            INavigationService navigationService,
            IRepository repository)
        {
            this.navigationService = navigationService;
            this.repository = repository;
        }

        public string LabelName => AppResources.LabelName;

        public string LabelDescription => AppResources.LabelDescription;

        public ICommand Close => new Command(async () =>
        {
            // TODO Popup when data is entered
            if (!string.IsNullOrEmpty(Name) || !string.IsNullOrEmpty(Description))
            {
                // do popup of custom dialog
            }

            // TODO use close of component
            await navigationService.NavigateBack(true);
        });

        public ICommand Save => new Command(async () =>
        {
            if (string.IsNullOrEmpty(Name))
            {
                // TODO Poup can't be saved
                return;
            }

            Workout workout = new Workout()
            {
                Name = this.Name,
                Description = Description ?? ""
            };

            repository.Insert(workout);

            // TODO use close of component
            await navigationService.NavigateBack(true);
        });

        public string? Name
        {
            get => name;
            set
            {
                name = value;
                NotifyPropertyChanged();
            }
        }

        public string? Description
        {
            get => description;
            set
            {
                description = value;
                NotifyPropertyChanged();
            }
        }
    }
}
