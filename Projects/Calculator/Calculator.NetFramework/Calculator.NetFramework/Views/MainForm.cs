using Calculator.Models.Enums;
using Calculator.NetFramework.Presenters;
using System;
using System.Windows.Forms;

namespace Calculator.NetFramework.Views
{
    public partial class MainForm : Form
    {
        private readonly MainPresenter presenter;

        public MainForm(IServiceProvider services)
        {
            InitializeComponent();
            presenter = new MainPresenter(this, services);
        }

        public void ShowMenu(UserControl ui)
        {
            MenuContent.Controls.Clear();
            ui.Dock = DockStyle.Fill;
            MenuContent.Controls.Add(ui);
        }

        private void 표준ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.GetMenu(MenuType.Standard);
        }

        private void 날짜계산ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.GetMenu(MenuType.Date);
        }
    }
}
