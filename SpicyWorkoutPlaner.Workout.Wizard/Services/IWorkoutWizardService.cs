using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyWorkoutPlaner.Workout.Wizard.Services
{
    public interface IWorkoutWizardService
    {
        /// <summary>
        /// Readonly properties
        /// </summary>
        Core.Models.Workout Workout { get; }

        /// <summary>
        /// Initializes a new workout for the wizard process
        /// </summary>
        void StartWizard();

        /// <summary>
        /// UpSert the created workout into database
        /// </summary>
        void FinishWizard();

        /// <summary>
        /// Nulls the created workout the abort the creation process
        /// </summary>
        void AbortWizard();
    }
}
