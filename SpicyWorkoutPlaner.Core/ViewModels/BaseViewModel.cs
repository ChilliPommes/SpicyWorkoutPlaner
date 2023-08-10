using SpicyWorkoutPlaner.Core.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SpicyWorkoutPlaner.Core.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected INavigationService NavigationService { get; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public void NotifyPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
