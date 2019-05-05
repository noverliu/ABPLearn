using System.Web.Mvc;

namespace PPG.Production.Web.Controllers
{
    public class AboutController : ProductionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}