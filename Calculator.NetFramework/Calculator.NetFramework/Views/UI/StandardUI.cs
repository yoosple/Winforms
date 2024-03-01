using Calculator.NetFramework.Presenters;
using System.Windows.Forms;

namespace Calculator.NetFramework.Views
{
    internal partial class StandardUI : UserControl
    {
        private readonly StandardPresenter presenter;

        public StandardUI(StandardPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        public void ShowHistory(string history)
        {
            if (string.IsNullOrEmpty(history))
            {
                history = "기록된 것이 나온다.";
            }

            labelHistory.Text = history;
        }

        private void buttonGetHistory_Click(object sender, System.EventArgs e)
        {
            presenter.GetHistory();
        }
    }
}
