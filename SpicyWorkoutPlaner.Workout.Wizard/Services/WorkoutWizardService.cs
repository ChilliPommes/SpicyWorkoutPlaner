using SpicyWorkoutPlaner.Database;

namespace SpicyWorkoutPlaner.Workout.Wizard.Services
{
    public class WorkoutWizardService : IWorkoutWizardService
    {
        private readonly WorkoutRepository workoutRepository;

        private Core.Models.Workout workout;

        /// <summary>
        /// Constuctor with injection
        /// </summary>
        /// <param name="workoutRepository"><see cref="WorkoutRepository"/></param>
        public WorkoutWizardService(WorkoutRepository workoutRepository) 
        {
            this.workoutRepository = workoutRepository;
        }

        /// <summary>
        /// Readonly properties
        /// </summary>
        public Core.Models.Workout Workout { get { return workout; } }

        /// <summary>
        /// Initializes a new workout for the wizrd process
        /// </summary>
        public void StartWizard()
        {
            workout = new Core.Models.Workout();
        }

        /// <summary>
        /// Upserts the created workout into database
        /// </summary>
        public void FinishWizard()
        {
            workoutRepository.Upsert(workout);
        }

        /// <summary>
        /// Nulls the created workout the abort the creation process
        /// </summary>
        public void AbortWizard()
        {
            workout = null;
        }
    }
}
