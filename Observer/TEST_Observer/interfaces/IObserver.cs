using TEST_Observer.Models;

namespace TEST_Observer
{
    public interface IObserver
    {
        void UpdateInfo(UserInfo userInfo);
    }
}
