using SpicyWorkoutPlaner.Core.Models;

namespace SpicyWorkoutPlaner.Planer.Models
{
    public sealed class Workout : DataBaseCore
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
