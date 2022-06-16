using Realms;
using SpicyWorkoutPlaner.Core.Services;
using SpicyWorkoutPlaner.Planer.Models;

namespace SpicyWorkoutPlaner.Planer.Repositories
{
    public class WorkoutExerciseRepository : Repository
    {
        public List<WorkoutExercise> GetAllByWorkoutId(long workoutId)
        {
            var realm = Realm.GetInstance(configuration);

            if (realm == null)
                throw new NullReferenceException("database can't be null");

            return realm.All<WorkoutExercise>().Where(x => x.Id == workoutId).ToList();
        }
    }
}
