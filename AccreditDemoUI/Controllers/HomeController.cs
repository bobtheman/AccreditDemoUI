using AccreditDemoUI.Helpers;
using NLog;
using System.Web.Mvc;

namespace AccreditDemoUI.Controllers
{
    public class HomeController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            logger.Info("Invoking action " + MethodName.GetCallerName());
            return View();
        }
    }
}