using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commnetValues = new List<UserComment>
			{
				new UserComment
				{
					ID=1,
					UserName="Yusf"
				},
				new UserComment
				{
					ID=2,
					UserName="Yuaasf"
				},
				new UserComment
				{
					ID=3,
					UserName="Yussf"
				}
			};
			return View(commnetValues);
		}
	}
}
