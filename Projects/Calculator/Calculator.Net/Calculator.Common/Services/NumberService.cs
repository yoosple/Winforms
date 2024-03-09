using Calculator.Common.Enums;
using Calculator.Common.Interfaces;
using Calculator.Models;
using Calculator.Models.Enums;

namespace Calculator.Common.Services
{
    public class NumberService : INumberService
    {
        public string GetHistory(MenuType menuType)
        {
            History history = new History();
            string result = string.Empty;

            switch (menuType)
            {
                case MenuType.Standard:
                    {   result = history.InputNumbers.First().ToString();
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
                    }
                    break;
            }

            return result;
        }
    }
}
