using Microsoft.AspNetCore.Identity;

namespace DesignPattern.ObserverMethod.DAL
{
    public class AppUser : IdentityUser<int> 
    {
        public string Name { get; set; }
        public string NameSurname { get; set; }
        public string City { get; set; }
        public string Disctrict { get; set; }
    }
}
