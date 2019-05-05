using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace PPG.Production.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ProductionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}