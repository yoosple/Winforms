using Calculator.NetFramework.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.NetFramework.Views
{
    internal partial class DateUI : UserControl
    {
        private readonly DatePresenter Presenter;

        public DateUI(DatePresenter presenter)
        {
            InitializeComponent();
            Presenter = presenter;
        }
    }
}
