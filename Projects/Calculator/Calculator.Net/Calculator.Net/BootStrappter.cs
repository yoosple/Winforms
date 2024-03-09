using Calculator.Common.Base;
using Calculator.Common.Interfaces;
using Calculator.Common.Services;
using Calculator.Net.ViewModels.Menu;
using Calculator.Net.Views;
using Calculator.Net.Views.Menu;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.ServiceAgent
{
    public class BootStrappter
    {
        public static void GetServices(out IServiceProvider service) 
        {
            CommonRegister.Initialize(out ServiceCollection collections);

            collections.AddSingleton<MainView>();
            collections.AddSingleton<StandardView>();
            collections.AddSingleton<DateView>();

            collections.AddSingleton<StandardViewModel>();
            collections.AddSingleton<DateViewModel>();

            service = collections.BuildServiceProvider();
        }

    }
}
