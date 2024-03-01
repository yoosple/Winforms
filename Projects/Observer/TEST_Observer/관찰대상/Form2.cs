using System.Windows.Forms;
using TEST_Observer.Models;

namespace TEST_Observer
{
    public partial class Form2 : Form, IObserver
    {
        ISubject subject;

        public Form2(ISubject _subject)
        {
            subject = _subject;
            subject.Attach(this);
            InitializeComponent();
        }

        public void UpdateInfo(UserInfo userInfo)
        {
            labelUserName.Text = userInfo.UserName;
        }

        private void buttonUpdate_Click(object sender, System.EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = textBoxUserName.Text;
            subject.Notify(userInfo);
        }
    }
}
