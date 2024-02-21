using Microsoft.AspNetCore.Mvc;

namespace smartAdmin.View_Components._layoutPartials
{
	public class _headerPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{  return View(); }
	}
}
