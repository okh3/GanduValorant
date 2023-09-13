using GanduValorant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GanduValorant.Services.ApplicationStatus
{
    public class ApplicationStatusManager : IApplicationStatusManager
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
