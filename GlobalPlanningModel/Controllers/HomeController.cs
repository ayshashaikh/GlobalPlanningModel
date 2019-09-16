using System.Web.Mvc;
using GlobalPlanningModel.Models.Interfaces;
using PagedList;

namespace GlobalPlanningModel.Controllers
{
    public class HomeController : Controller
    {

        private readonly IXmlReaderService _xmlFileReaderService;
        public HomeController(IXmlReaderService xmlFileReader)
        {
            _xmlFileReaderService = xmlFileReader;
        }
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            var path = System.Web.HttpContext.Current.Server.MapPath($"~/App_Data/Data.xml");
            var scenarios= _xmlFileReaderService.ReadAllScenarios(path);

            //arranging pagination for view
            ViewBag.CurrentSort = sortOrder;
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(scenarios.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}