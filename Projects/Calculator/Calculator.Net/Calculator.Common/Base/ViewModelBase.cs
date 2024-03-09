using CommunityToolkit.Mvvm.ComponentModel;

namespace Calculator.Common.Base
{
    public class ViewModelBase : ObservableObject
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public ViewModelBase() 
        { 
        }

        public ViewModelBase(IServiceProvider service) : base()
        { 
            ServiceProvider = service;
        }
    }
}
