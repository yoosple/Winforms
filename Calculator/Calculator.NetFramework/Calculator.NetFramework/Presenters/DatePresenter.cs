using Calculator.NetFramework.Interfaces;
using Calculator.NetFramework.Views;
using System.Windows.Forms;

namespace Calculator.NetFramework.Presenters
{
    internal class DatePresenter : IDateService
    {
        DateUI DateUI;

        public DatePresenter()
        {
            DateUI standardUI = new DateUI(this);
            DateUI = standardUI;
        }

        public UserControl CreateUI()
        {
            return DateUI;
        }
    }
}
