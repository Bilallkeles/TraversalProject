using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Statistic:ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.destinations.Count();
            ViewBag.v2= c.guides.Count();
            ViewBag.v3 = "285";
            return View();
        }

    }
}
