using System.Web.Mvc;
using WEB.DataAccess;
using static WEB.Models.MainModel;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {

        private string lang = Comond.SetLanguage();

        public ActionResult Index()
        {
            var list_detail = BaseConnectionSql.ExecuteList_Helper<objcheckbox>("web", "spCategories_GetByPK", null);
            ViewBag.list_detail = list_detail;
            var list_product = BaseConnectionSql.ExecuteList_Helper<objTop3Product>("web", "sp_Top3Product");
            ViewBag.list_product = list_product;
            var list_BestSeller = BaseConnectionSql.ExecuteList_Helper<objTop3Product>("web", "sp_ListBestSeller");
            ViewBag.list_BestSeller = list_BestSeller;
            return View();
        }

        public ActionResult Language(string lang)
        {
            System.Web.HttpContext.Current.Session["lang"] = lang;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}