using SpicyWorkoutPlaner.Core.ViewModels;
using SpicyWorkoutPlaner.Planer.ViewModels.ListItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyWorkoutPlaner.Planer.ViewModels.Workouts
{
    public class WorkoutDetailPageViewModel : BaseViewModel
    {
        private WorkoutListItemViewModel workoutListItemViewModel;

        public void SetItem(WorkoutListItemViewModel workoutListItemViewModel)
        {
            this.workoutListItemViewModel = workoutListItemViewModel;
        }
    }
}
