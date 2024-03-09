using Calculator.Net.ViewModels.Menu;

namespace Calculator.Net.Views.Menu
{
    public partial class StandardView : UserControl
    {
        readonly StandardViewModel viewModel;

        public StandardView()
        {
            InitializeComponent();
            viewModel = new StandardViewModel();
            Load += StandardView_Load;
        }

        private void StandardView_Load(object sender, EventArgs e)
        {
            labelTitle.DataBindings.Add("Text", viewModel, nameof(viewModel.Title));
            labelHistory.DataBindings.Add("Text", viewModel, nameof(viewModel.History));
            buttonHistory.Command = viewModel.GetHistoryCommand;
        }
    }
}
