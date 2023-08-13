using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GanduValorant.Models.App;

namespace GanduValorant.Services.ApplicationStatus
{
    public interface IApplicationStatusManager
    {
        void SetApplicationStatus(AppStates.States state);
        AppStates.States GetApplicationStatus();
    }
}
