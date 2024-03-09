using Calculator.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Common.Interfaces
{
    public interface INumberService
    {
        public string GetHistory(MenuType menuType);
    }
}
