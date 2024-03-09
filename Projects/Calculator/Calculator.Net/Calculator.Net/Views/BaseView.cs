namespace Calculator.Net.Views
{
    public partial class BaseView : Form
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public BaseView()
        {
            InitializeComponent();
        }

        public BaseView(IServiceProvider service) : base()
        {
            ServiceProvider = service;
        }
    }
}
