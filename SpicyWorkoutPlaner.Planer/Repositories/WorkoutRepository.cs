using Realms;
using SpicyWorkoutPlaner.Core.Services;
using SpicyWorkoutPlaner.Planer.Models;

namespace SpicyWorkoutPlaner.Planer.Repositories
{
    public class WorkoutRepository : Repository
    {
        public List<Workout> GetAll()
        {
            var realm = Realm.GetInstance(configuration);

            if (realm == null)
                throw new NullReferenceException("database can't be null");

            return realm.All<Workout>().ToList();
        }
    }
}
