using Realms;
using SpicyWorkoutPlaner.Core.Models;
using SpicyWorkoutPlaner.Core.Services;

namespace SpicyWorkoutPlaner.Database
{
    public class WorkoutRepository : Repository
    {
        public List<Workout> GetAll()
        {
            using var realm = Realm.GetInstance(configuration);

            if (realm == null)
                throw new NullReferenceException("database can't be null");

            return realm.All<Workout>().ToList();
        }

        public Workout? GetOneById(string id)
        {
            using var realm = Realm.GetInstance(configuration);

            if (realm == null)
                throw new NullReferenceException("database can't be null");

            return realm.All<Workout>()
                .FirstOrDefault(x => x.Id == id);
        }

        public void Upsert(Workout workout)
        {
            using var realm = Realm.GetInstance(configuration);

            if (realm == null)
                throw new NullReferenceException("database can't be null");

            realm.Write(() =>
            {
                realm.Add(workout, update: true);
            });
        }
    }
}
