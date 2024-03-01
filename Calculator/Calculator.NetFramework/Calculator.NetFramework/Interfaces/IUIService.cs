using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.NetFramework.Interfaces
{
    internal interface IUIService
    {
        UserControl CreateUI();
    }
}
