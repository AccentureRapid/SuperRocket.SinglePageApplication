using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SuperRocket.SinglePageApplication.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SinglePageApplicationControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}