using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            //ViewBag.planType = netflixPlans.PlanType("Temel Plan");
            //ViewBag.countPerson = netflixPlans.CountPerson(1);
            //ViewBag.price = netflixPlans.Price(65.99);
            //ViewBag.content = netflixPlans.Content("Film-Dizi");
            //ViewBag.resolution = netflixPlans.Resolution("480px");
            netflixPlans.CreatePlan();

            return View(netflixPlans);
        }

        public IActionResult StandardPlanIndex()
        {
            NetflixPlans netflixPlans = new StandardPlan();
            ViewBag.planType = netflixPlans.PlanType("Standart Plan");
            ViewBag.countPerson = netflixPlans.CountPerson(2);
            ViewBag.price = netflixPlans.Price(94.99);
            ViewBag.content = netflixPlans.Content("Film-Dizi-Animasyon");
            ViewBag.resolution = netflixPlans.Resolution("720px");

            return View(netflixPlans);
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.planType = netflixPlans.PlanType("Ultra Plan");
            ViewBag.countPerson = netflixPlans.CountPerson(4);
            ViewBag.price = netflixPlans.Price(134.99);
            ViewBag.content = netflixPlans.Content("Film-Dizi-Animasyon-Belgesel");
            ViewBag.resolution = netflixPlans.Resolution("1080px");

            return View(netflixPlans);
        }
    }
}
