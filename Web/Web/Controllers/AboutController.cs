using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Web.Controllers
{
    public class AboutController : Controller
    {
        WriterManager bm = new WriterManager(new EfWriterRepository());
        AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = abm.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
            var values = bm.GetList();
            return PartialView(values);
        }
    }
}
