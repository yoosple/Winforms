using Calculator.Models;
using Calculator.Models.Enums;
using Calculator.NetFramework.Interfaces;
using Calculator.NetFramework.Views;
using System.Linq;
using System.Windows.Forms;

namespace Calculator.NetFramework.Presenters
{
    internal class StandardPresenter : IStandardService
    {
        StandardUI StandardUI;

        public StandardPresenter()
        {
            StandardUI standardUI = new StandardUI(this);
            StandardUI = standardUI;
        }

        public UserControl CreateUI()
        {
            return StandardUI;
        }

        public void GetHistory()
        {
            History history = new History();
            string result = history.InputNumbers.First().ToString();

            for (int i = 0; i < history.InputSymbols.Count(); i++)
            {
                decimal nextNumber = history.InputNumbers.ElementAt(i + 1);
                switch (history.InputSymbols.ElementAt(i))
                {
                    case SymbolType.Addition:
                        result += " + " + nextNumber;
                        break;
                    case SymbolType.Subtraction:
                        result += " - " + nextNumber;
                        break;
                    case SymbolType.Multiplication:
                        result += " * " + nextNumber;
                        break;
                    case SymbolType.Division:
                        result += " / " + nextNumber;
                        break;
                }
            }

            StandardUI.ShowHistory(result);
        }
    }
}
