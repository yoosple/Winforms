using Calculator.Common.Base;
using Calculator.Net.Views;
using Calculator.ServiceAgent;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Net
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

            BootStrappter.GetServices(out var services);
            _ = new ViewModelBase(services);
            _ = new BaseView(services);

            MainView mainView = services.GetRequiredService<MainView>();
            Application.Run(mainView);
        }
    }
}