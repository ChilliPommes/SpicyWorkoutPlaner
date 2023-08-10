using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyWorkoutPlaner.Core.Interfaces
{
    public interface INavigationService
    {
        Task NavigateTo(string route);
    }
}
