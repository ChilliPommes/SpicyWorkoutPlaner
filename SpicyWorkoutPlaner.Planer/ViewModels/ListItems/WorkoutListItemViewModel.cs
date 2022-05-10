using SpicyWorkoutPlaner.Planer.Models;

namespace SpicyWorkoutPlaner.Planer.ViewModels.ListItems
{
    public class WorkoutListItemViewModel
    {
        public WorkoutListItemViewModel(Workout workout, List<WorkoutExercise> exercises)
        {
            Workout = workout;
            Exercises = exercises;
        }

        public string Name => Workout.Name;

        public string Description => Workout.Description;

        public byte ExerciseCount => (byte)Exercises.Count;

        public Workout Workout { get; }

        public List<WorkoutExercise> Exercises { get; }
    }
}
