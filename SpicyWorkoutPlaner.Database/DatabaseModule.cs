using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyWorkoutPlaner.Database
{
    /// <summary>
    /// Static Class WizardModule used for initializing the component and function module
    /// </summary>
    public static class DatabaseModule
    {
        /// <summary>
        /// Initialise workout wizard module and registers all necessary service, views and viewmodels
        /// </summary>
        /// <param name="serviceCollection"><see cref="IServiceCollection"/></param>
        public static void InitializeDatabaseModule(this IServiceCollection serviceCollection)
        {
            // Register servies here
            serviceCollection.AddSingleton<WorkoutRepository>();
            serviceCollection.AddSingleton<WorkoutExerciseRepository>();
        }
    }
}
