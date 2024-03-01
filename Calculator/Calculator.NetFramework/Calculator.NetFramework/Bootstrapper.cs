using Calculator.NetFramework.Interfaces;
using Calculator.NetFramework.Presenters;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Calculator.NetFramework
{
    internal class Bootstrapper
    {
        public Bootstrapper(out IServiceProvider services) 
        {
            services = GetServices();
        }

        private IServiceProvider GetServices()
        {
            var _services = new ServiceCollection();

            _services.AddSingleton<IStandardService, StandardPresenter>();
            _services.AddSingleton<IDateService, DatePresenter>();

            return _services.BuildServiceProvider();
        }
    }
}
