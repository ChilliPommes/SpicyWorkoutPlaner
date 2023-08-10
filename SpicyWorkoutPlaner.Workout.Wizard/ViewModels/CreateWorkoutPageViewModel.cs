using SpicyWorkoutPlaner.Core.Interfaces;
using SpicyWorkoutPlaner.Core.ViewModels;
using SpicyWorkoutPlaner.Workout.Wizard.Services;
using SpicyWorkoutPlaner.Workout.Wizard.Views;
using System.Windows.Input;

namespace SpicyWorkoutPlaner.Workout.Wizard.ViewModels
{
    /// <summary>
    /// View model for <see cref="CreateWorkoutPage"/>
    /// </summary>
    public class CreateWorkoutPageViewModel : BaseViewModel
    {
        private readonly IWorkoutWizardService workoutWizardService;

        private bool _staticCheck;
        private bool _flexCheck;

        public CreateWorkoutPageViewModel(
            INavigationService navigationService,
            IWorkoutWizardService workoutWizardService) : base(navigationService)
        {
            this.workoutWizardService = workoutWizardService;

            workoutWizardService.StartWizard();
        }

        public string WorkoutName
        {
            get => workoutWizardService.Workout?.Name ?? "";

            set
            {
                if (workoutWizardService.Workout != null)
                {
                    workoutWizardService.Workout.Name = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(CanCreate));
                }
            }
        }

        public bool StaticCheck
        {
            get => _staticCheck;
            set
            {
                _staticCheck = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged(nameof(CanCreate));
            }
        }

        public bool FlexCheck
        {
            get => _flexCheck;
            set
            {
                _flexCheck = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged(nameof(CanCreate));
            }
        }

        public bool CanCreate => !string.IsNullOrEmpty(WorkoutName) && (FlexCheck || StaticCheck);

        public ICommand CreateCommand => new Command(() =>
        {
            workoutWizardService.Workout.Name = WorkoutName;
            workoutWizardService.Workout.IsFlex = FlexCheck;
            workoutWizardService.Workout.IsStatic = StaticCheck;

            NavigationService.NavigateTo("workout/creation/manage-exercises");
        });
    }
}
