using DesignPattern.ObserverMethod.DAL;
using System;

namespace DesignPattern.ObserverMethod.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.NameSurname,
                Content = "Dergi Bültenimize Kayıt Olduğunuz İçin Çok Teşekkür Ederiz, Dergilerimize Web Sitemizden Ulaşabilirsiniz"
            });
            context.SaveChanges();
        }
    }
}
