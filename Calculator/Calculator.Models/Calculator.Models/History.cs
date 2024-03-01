using Calculator.Models.Enums;
using System.Collections.Generic;

namespace Calculator.Models
{
    public class History
    {
        public IEnumerable<decimal> InputNumbers { get; set; }
        public IEnumerable<SymbolType> InputSymbols { get; set; }

        public History()
        {
            InputNumbers = new List<decimal>()
        {
            123,
            456
        };
            InputSymbols = new List<SymbolType>
        {
            SymbolType.Multiplication
        };
        }
    }
}
