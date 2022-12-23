using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		public PartialViewResult CommentByBlog() {
			return PartialView();
		}
	}
}
