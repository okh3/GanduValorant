using GanduValorant.Models.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GanduValorant.Services.ApplicationStatus
{
    public class EnumApplicationStatesManager : IApplicationStatusManager
    {
        AppStates.States _currentState;

        public AppStates.States GetApplicationStatus()
        {
            return _currentState;
        }

        public void SetApplicationStatus(AppStates.States state)
        {
            _currentState = state;
        }
    }
}
