using Calculator.Net.ViewModels.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Net.Views.Menu
{
    public partial class DateView : UserControl
    {
        public DateView()
        {
            InitializeComponent();
            DataContext = new DateViewModel();
        }
    }
}
