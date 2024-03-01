using System.Windows.Forms;
using TEST_Observer.Models;

namespace TEST_Observer
{
    public partial class Form3 : Form, IObserver
    {
        ISubject subject;

        public Form3(ISubject _subject)
        {
            subject = _subject;
            subject.Attach(this);
            InitializeComponent();
        }

        public void UpdateInfo(UserInfo userInfo)
        {
            labelUserName.Text = userInfo.UserName;
        }
    }
}