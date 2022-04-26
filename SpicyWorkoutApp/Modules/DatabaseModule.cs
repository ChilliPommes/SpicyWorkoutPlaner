using SpicyWorkoutPlaner.Core.Services;
using SpicyWorkoutPlaner.Planer.Models;
using SQLite;

namespace SpicyWorkoutApp.Modules
{
    public static class DatabaseModule
    {
        public static void InitializeDatabase()
        {
            var sqlconnection = DataBaseConnection.Instance.Connection;
            SQLiteCommand cmd = sqlconnection.CreateCommand("SELECT name FROM sqlite_master WHERE type='table';");
            var result = cmd.ExecuteQueryScalars<string>().ToList();

            if (!result.Any(x => x.Equals(nameof(Workout))))
            {
                sqlconnection.CreateTable<Workout>(createFlags: CreateFlags.None);
            }

            if (!result.Any(x => x.Equals(nameof(WorkoutExercise))))
            {
                sqlconnection.CreateTable<WorkoutExercise>(createFlags: CreateFlags.None);
            }

            if (!result.Any(x => x.Equals(nameof(WorkoutRepitition))))
            {
                sqlconnection.CreateTable<WorkoutRepitition>(createFlags: CreateFlags.None);
            }

            if (!result.Any(x => x.Equals(nameof(WorkoutSet))))
            {
                sqlconnection.CreateTable<WorkoutSet>(createFlags: CreateFlags.None);
            }
        }
    }
}
