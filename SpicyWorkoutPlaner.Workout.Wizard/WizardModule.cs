using Microsoft.Extensions.DependencyInjection;
using SpicyWorkoutPlaner.Workout.Wizard.Services;
using SpicyWorkoutPlaner.Workout.Wizard.ViewModels;
using SpicyWorkoutPlaner.Workout.Wizard.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyWorkoutPlaner.Workout.Wizard
{
    /// <summary>
    /// Static Class WizardModule used for initializing the component and function module
    /// </summary>
    public static class WizardModule
    {
        /// <summary>
        /// Initialise workout wizard module and registers all necessary service, views and viewmodels
        /// </summary>
        /// <param name="serviceCollection"><see cref="IServiceCollection"/></param>
        public static void InitializeWizardModule(this IServiceCollection serviceCollection)
        {
            // Register servies here
            serviceCollection.AddSingleton<IWorkoutWizardService, WorkoutWizardService>();

            // Register view here
            Routing.RegisterRoute("workout/creation/create", typeof(CreateWorkoutPage));
            Routing.RegisterRoute("workout/creation/manage-exercises", typeof(ExerciseManagePage));

            // Register viewmodels here
            serviceCollection.AddTransient<CreateWorkoutPageViewModel>();
        }
    }
}
