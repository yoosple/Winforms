using Calculator.Common.Base;
using Calculator.Common.Enums;
using Calculator.Common.Interfaces;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;

namespace Calculator.Net.ViewModels.Menu
{
    public class StandardViewModel : ViewModelBase
    {
        readonly Lazy<INumberService> numberService;

        private string title;
        private string history;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public string History
        {
            get => history;
            set => SetProperty(ref history, value);
        }

        public StandardViewModel() 
        { 
            numberService = new Lazy<INumberService>(ServiceProvider.GetRequiredService<INumberService>());

            Title = "표준";

            GetHistoryCommand = new RelayCommand(GetHistory);
        }

        public ICommand GetHistoryCommand { get; set; }

        private void GetHistory()
        {
            History = numberService.Value.GetHistory(MenuType.Standard);
        }
    }
}
