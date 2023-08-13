using GanduValorant.Services.DependancyInjection;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.DataFormats;

namespace GanduValorant
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = DependancyConfiguration.Configure();
            var mainForm = serviceProvider.GetRequiredService<MainWindow>();
            Application.Run(mainForm);
            
        }
    }
}