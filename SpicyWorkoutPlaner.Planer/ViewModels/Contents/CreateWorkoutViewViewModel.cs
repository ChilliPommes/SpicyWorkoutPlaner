using SpicyWorkoutPlaner.Core.Interfaces;
using SpicyWorkoutPlaner.Core.Resx;
using SpicyWorkoutPlaner.Core.ViewModels;
using SpicyWorkoutPlaner.Planer.Models;
using SpicyWorkoutPlaner.Planer.Repositories;
using System.Windows.Input;

namespace SpicyWorkoutPlaner.Planer.ViewModels.Contents
{
    public class CreateWorkoutViewViewModel : BaseViewModel
    {
        private readonly INavigationService navigationService;
        private readonly WorkoutRepository workoutRepository;
        private string? name;
        private string? description;

        public event EventHandler ItemCreated;

        public CreateWorkoutViewViewModel(
            INavigationService navigationService,
            WorkoutRepository workoutRepository)
        {
            this.navigationService = navigationService;
            this.workoutRepository = workoutRepository;
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
                Description = Description ?? "",
                CreatedAt = DateTime.Now,
            };

            workoutRepository.Insert(workout);

            NotifyItemCreated();

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

        private void NotifyItemCreated()
        {
            ItemCreated?.Invoke(this, new EventArgs());
        }
    }
}
