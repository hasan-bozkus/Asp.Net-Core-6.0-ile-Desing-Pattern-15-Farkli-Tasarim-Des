using DesignPattern.ObserverMethod.DAL;

namespace DesignPattern.ObserverMethod.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
