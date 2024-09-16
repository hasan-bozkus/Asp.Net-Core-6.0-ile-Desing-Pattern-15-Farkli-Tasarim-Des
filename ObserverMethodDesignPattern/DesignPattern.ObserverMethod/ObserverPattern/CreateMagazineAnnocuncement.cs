using DesignPattern.ObserverMethod.DAL;
using System;

namespace DesignPattern.ObserverMethod.ObserverPattern
{
    public class CreateMagazineAnnocuncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnocuncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.NameSurname,
                Magazine = "Bilişim Dergisi",
                Content = "Bilişim Dergimizin Mart Sayısı 1 Martta evinize ulaştırılacaktır, konular Jupiter Gezegeni ve Mars Olacaktır."
            });
            context.SaveChanges();
        }
    }
}
