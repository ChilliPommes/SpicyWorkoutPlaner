using SpicyWorkoutPlaner.Core.Interfaces;
using SpicyWorkoutPlaner.Core.Services;
using SpicyWorkoutPlaner.Core.ViewModels;
using SpicyWorkoutPlaner.Planer.Controls;
using SpicyWorkoutPlaner.Planer.Models;
using SpicyWorkoutPlaner.Planer.ViewModels.ListItems;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SpicyWorkoutPlaner.Planer.ViewModels
{
    public class CreateWorkoutPageViewModel : BaseViewModel
    {
        private readonly INavigationService navigationService;
        private readonly IServiceProvider serviceProvider;
        private readonly IRepository repository;

        private ObservableCollection<WorkoutListItemViewModel> items;

        public CreateWorkoutPageViewModel(
            INavigationService navigationService,
            IServiceProvider serviceProvider,
            IRepository repository)
        {
            this.navigationService = navigationService;
            this.serviceProvider = serviceProvider;
            this.repository = repository;

            LoadWorkOuts();
        }

        public WorkoutListItemViewModel SelectedItem { get; set; }

        public ObservableCollection<WorkoutListItemViewModel> Items
        {
            get => items;
            set
            {
                items = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand AddCommand => new Command(async () =>
        {
            var view = serviceProvider.GetService<CreateWorkoutView>();

            if (view is not null)
            {
                view.RegisterItemCreateEvent((o, e) => { LoadWorkOuts(); });

                await navigationService.NavigateTo(new BottomSheetPage()
                {
                    SheetContent = view
                }, true);
            }
        });

        public ICommand ItemSelectionChanged => new Command(() =>
        {
            // TODO fill with life
        });

        private void LoadWorkOuts()
        {
            if (Items == null)
            {
                Items = new ObservableCollection<WorkoutListItemViewModel>();
            }
            else
            {
                Items.Clear();
            }

            var workouts = repository.FindAll<Workout>(x => x.DeletedAt == null);

            foreach (var workout in workouts)
            {
                var exercises = repository.FindAll<WorkoutExercise>(x => x.WorkoutId == workout.Id);

                var itemViewModel = new WorkoutListItemViewModel(workout, exercises);

                Items.Add(itemViewModel);
            }
        }
    }
}
