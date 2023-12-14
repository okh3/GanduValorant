using GanduValorant.Services.ApplicationStatus;
using GanduValorant.Services.ColorCapturing;
using GanduValorant.Services.InputManagement.KeyboardControl;
using GanduValorant.Services.InputManagement.MouseControl;
using GanduValorant.Services.ConfigManager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GanduValorant.Services.AccountManagement.Login;
using GanduValorant.Forms;

namespace GanduValorant.Services.DependancyInjection
{
    public static class DependancyConfiguration
    {
        public static IServiceProvider Configure()
        {
            var services = new ServiceCollection();
            services.AddSingleton <IPixleColorCapture, PixleColorCapture>();
            services.AddSingleton<IMouseController, MouseController>();
            services.AddSingleton<IKeyboardInputCapture, KeyboardInputCapture>();
            services.AddSingleton<IApplicationStatusManager, ApplicationStatusManager>();
            services.AddSingleton<IConfigManager>(provider =>
            {
                var path = Application.ExecutablePath + ".gandu.config";
                return new ConfigManager.ConfigManager(path);
            });
            
            // Register MainWindow
            services.AddTransient<MainWindow>();
            services.AddSingleton<IGanduCheatsLogin, GanduCheatsLogin>();

            services.AddTransient<LoginForm>();
            return services.BuildServiceProvider();
        }
    }
}
