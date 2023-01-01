using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.ViewComponents.Statics
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke() {
            ViewBag.v1=bm.GetList().Count();   
            ViewBag.v2=c.Contacts.Count();
            return View(); }

    }
}
