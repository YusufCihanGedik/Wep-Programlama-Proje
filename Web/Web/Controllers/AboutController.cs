﻿using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}