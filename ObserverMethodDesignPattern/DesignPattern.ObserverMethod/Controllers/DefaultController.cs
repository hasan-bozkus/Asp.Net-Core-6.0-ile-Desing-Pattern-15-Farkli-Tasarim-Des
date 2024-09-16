using DesignPattern.ObserverMethod.DAL;
using DesignPattern.ObserverMethod.Models;
using DesignPattern.ObserverMethod.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPattern.ObserverMethod.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            var appUser = new AppUser()
            {
                Name = registerViewModel.Name,
                NameSurname = registerViewModel.Surname,
                Email = registerViewModel.Email,
                UserName = registerViewModel.UserName
            };
            var result = await _userManager.CreateAsync(appUser, registerViewModel.Password);
            if(result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser);
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }
    }
}
