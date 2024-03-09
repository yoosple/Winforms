using Calculator.Net.ViewModels;
using Calculator.Net.Views.Menu;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator.Net.Views
{
    public partial class MainView : BaseView
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            var view = ServiceProvider.GetRequiredService<StandardView>();
            SetMenuContent(view);
        }

        private void 표준ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = ServiceProvider.GetRequiredService<StandardView>();
            SetMenuContent(view);
        }

        private void 날짜계산ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = ServiceProvider.GetRequiredService<DateView>();
            SetMenuContent(view);
        }

        private void SetMenuContent(Control control)
        {
            MenuContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            MenuContent.Controls.Add(control);
        }
    }
}