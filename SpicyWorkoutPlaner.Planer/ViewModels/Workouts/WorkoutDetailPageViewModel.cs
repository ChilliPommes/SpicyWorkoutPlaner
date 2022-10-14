using Microsoft.Extensions.DependencyInjection;
using SpicyWorkoutPlaner.Core.Interfaces;
using SpicyWorkoutPlaner.Core.ViewModels;
using SpicyWorkoutPlaner.Planer.Controls;
using SpicyWorkoutPlaner.Planer.ViewModels.ListItems;
using SpicyWorkoutPlaner.Planer.Views.Contents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SpicyWorkoutPlaner.Planer.ViewModels.Workouts
{
    public class WorkoutDetailPageViewModel : BaseViewModel
    {
        private WorkoutListItemViewModel? workoutListItemViewModel;
        private readonly INavigationService navigationService;
        private readonly IServiceProvider serviceProvider;

        public WorkoutDetailPageViewModel(
            INavigationService navigationService,
            IServiceProvider serviceProvider)
        {
            this.navigationService = navigationService;
            this.serviceProvider = serviceProvider;
        }

        public void SetItem(WorkoutListItemViewModel workoutListItemViewModel)
        {
            this.workoutListItemViewModel = workoutListItemViewModel;
        }

        public byte ExerciseCount => workoutListItemViewModel?.ExerciseCount ?? 0;

        public ICommand AddCommand => new Command(async () =>
        {
            var view = serviceProvider.GetService<CreateWorkoutExerciseView>();

            if (view is not null)
            {
                view.RegisterItemCreateEvent((o, e) => {  });

                await navigationService.NavigateTo(new BottomSheetPage()
                {
                    SheetContent = view
                }, true);
            }
        });
    }
}
