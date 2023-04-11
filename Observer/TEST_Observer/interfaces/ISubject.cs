using TEST_Observer.Models;

namespace TEST_Observer
{
    public interface ISubject
    {
        void Attach(IObserver o);
        void Detach(IObserver o);
        void Notify(UserInfo userInfo);
    }
}
