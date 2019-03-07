﻿using System.Diagnostics;
using System.Web.Mvc;
using BasicCompany.Feature.Navigation.Services;
using Sitecore.Mvc.Presentation;

namespace BasicCompany.Feature.Navigation.Controllers
{
	public class NavigationController : Controller
	{
		protected readonly IHeaderBuilder HeaderBuilder;

		public NavigationController(IHeaderBuilder headerBuilder)
		{
			Debug.Assert(headerBuilder != null);
			HeaderBuilder = headerBuilder;
		}

		public ActionResult Header()
		{
			var header = HeaderBuilder.GetHeader(RenderingContext.Current.ContextItem);
			return View(header);
		}
	}
}