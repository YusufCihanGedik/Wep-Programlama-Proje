using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic3 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.AdminName = c.Admins.Where(x => x.AdminID == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.UserName = c.Admins.Where(x => x.AdminID == 1).Select(y => y.UserName).FirstOrDefault();
            ViewBag.AdminDes = c.Admins.Where(x => x.AdminID == 1).Select(y => y.Descriotion).FirstOrDefault();
            return View();
        }
    }
}