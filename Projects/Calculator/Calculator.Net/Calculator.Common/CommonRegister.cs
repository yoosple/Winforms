using Calculator.Common.Interfaces;
using Calculator.Common.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.ServiceAgent
{
    public class CommonRegister
    {
        public static void Initialize(out ServiceCollection services)
        {
            var _services = new ServiceCollection();

            _services.AddSingleton<INumberService, NumberService>();
            _services.AddSingleton<IDateService, DateService>();

            services = _services;
        }
    }
}
