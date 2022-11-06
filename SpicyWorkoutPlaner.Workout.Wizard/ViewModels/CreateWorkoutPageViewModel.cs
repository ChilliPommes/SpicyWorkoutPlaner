using SpicyWorkoutPlaner.Core.ViewModels;
using SpicyWorkoutPlaner.Workout.Wizard.Services;
using SpicyWorkoutPlaner.Workout.Wizard.Views;

namespace SpicyWorkoutPlaner.Workout.Wizard.ViewModels
{
    /// <summary>
    /// View model for <see cref="CreateWorkoutPage"/>
    /// </summary>
    public class CreateWorkoutPageViewModel : BaseViewModel
    {
        private readonly WorkoutWizardService workoutWizardService;

        public CreateWorkoutPageViewModel(
            WorkoutWizardService workoutWizardService) 
        {
            this.workoutWizardService = workoutWizardService;
        }

        public string WorkoutName
        {
            get => workoutWizardService.Workout.Name;

            set
            {
                workoutWizardService.Workout.Name = value;
                NotifyPropertyChanged();
            }
        }
    }
}
