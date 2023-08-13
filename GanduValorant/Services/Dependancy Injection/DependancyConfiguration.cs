using GanduValorant.Services.ApplicationStatus;
using GanduValorant.Services.ColorCapturing;
using GanduValorant.Services.InputManagement.KeyboardControl;
using GanduValorant.Services.InputManagement.MouseControl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.DependancyInjection
{
    public static class DependancyConfiguration
    {
        public static IServiceProvider Configure()
        {
            var services = new ServiceCollection();
            services.AddSingleton <IPixleColorCapture, BitMapPixleColorCapture>();
            services.AddSingleton<IMouseController, User32MouseController>();
            services.AddSingleton<IKeyboardInputCapture, WinformKeyboardInputCapture>();
            services.AddSingleton<IApplicationStatusManager, EnumApplicationStatesManager>();
            // Register MainWindow
            services.AddTransient<MainWindow>();
            return services.BuildServiceProvider();
        }
    }
}
