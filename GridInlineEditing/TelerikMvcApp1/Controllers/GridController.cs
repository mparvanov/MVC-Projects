using System;
﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TelerikMvcApp1.Models;

namespace TelerikMvcApp1.Controllers
{
	public partial class GridController : Controller
    {
		//public ActionResult Orders_Read([DataSourceRequest]DataSourceRequest request)
		//{
		//	var result = Enumerable.Range(0, 50).Select(i => new OrderViewModel
		//	{
		//		OrderID = i,
		//		Freight = i * 10,
		//		OrderDate = DateTime.Now.AddDays(i),
		//		ShipName = "ShipName " + i,
		//		ShipCity = "ShipCity " + i
		//	});

		//	return Json(result.ToDataSourceResult(request));
		//}



        public ActionResult EditingInline_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(productService.Read().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Create([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.Create(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Update([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {
                productService.Update(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Destroy([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            if (product != null)
            {
                productService.Destroy(product);
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }
























    }
}
