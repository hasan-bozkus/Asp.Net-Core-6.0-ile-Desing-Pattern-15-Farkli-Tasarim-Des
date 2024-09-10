using DesignPattern.ChainOfResponsibility.ChaniOfResponsibility;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel customerProcessViewModel)
        {
            Employee truasurer = new Treasurer();
            Employee managerAssistant = new ManageAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            truasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            truasurer.PocessRequest(customerProcessViewModel);

            return RedirectToAction("Index");
        }
    }
}
