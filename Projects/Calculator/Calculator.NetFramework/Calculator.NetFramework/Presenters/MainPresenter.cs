using Calculator.Models.Enums;
using Calculator.NetFramework.Interfaces;
using Calculator.NetFramework.Views;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Calculator.NetFramework.Presenters
{
    internal class MainPresenter
    {
        private readonly MainForm form;
        private readonly IStandardService standardService;
        private readonly IDateService dateTimeService;

        public MainPresenter(MainForm form, IServiceProvider services)
        {
            this.form = form;
            standardService = services.GetService<IStandardService>();
            dateTimeService = services.GetService<IDateService>();
            form.ShowMenu(standardService.CreateUI());
        }

        public void GetMenu(MenuType menuType)
        {
            switch (menuType)
            {
                case MenuType.Standard:
                    {
                        form.ShowMenu(standardService.CreateUI());
                    }
                    break;
                case MenuType.Date:
                    {
                        form.ShowMenu(dateTimeService.CreateUI());
                    }
                    break;
            }
        }
    }
}
