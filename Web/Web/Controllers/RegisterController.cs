
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Web.Controllers
{
	
	public class RegisterController : Controller
	{
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator ww = new WriterValidator();
			ValidationResult results = ww.Validate(p);
			if (results.IsValid)
			{
				p.WriteStatus = true;
				p.WriterAbout = "Deneme Test";
				wm.WriterAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
