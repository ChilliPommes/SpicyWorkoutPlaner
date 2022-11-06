using Realms;
using SpicyWorkoutPlaner.Core.Models;
using SpicyWorkoutPlaner.Core.Services;

namespace SpicyWorkoutPlaner.Database
{
    public class WorkoutExerciseRepository : Repository
    {
        public List<WorkoutExercise> GetAllByWorkoutId(string workoutId)
        {
            var realm = Realm.GetInstance(configuration);

            if (realm == null)
                throw new NullReferenceException("database can't be null");

            return realm.All<WorkoutExercise>().Where(x => x.Id.Equals(workoutId)).ToList();
        }
    }
}
