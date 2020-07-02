using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcApp1.Models;

namespace TelerikMvcApp1.Controllers
{
    public partial class GridController : Controller
    {
        private ProductService productService;

        public GridController()
        {
            productService = new ProductService(new SampleEntities());
        }

        protected override void Dispose(bool disposing)
        {
            productService.Dispose();

            base.Dispose(disposing);
        }

        public ActionResult Basic_Usage()
        {
            return View();
        }

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(productService.Read().ToDataSourceResult(request));
        }

        public ActionResult Orders_Read([DataSourceRequest]DataSourceRequest request)
        {
            return Json(GetOrders().ToDataSourceResult(request));
        }

        public ActionResult Customers_Read([DataSourceRequest]DataSourceRequest request)
        {
            return Json(GetCustomers().ToDataSourceResult(request));
        }

        private static IEnumerable<CustomerViewModel> GetCustomers()
        {
            var northwind = new SampleEntities();
            return northwind.Customers.Select(customer => new CustomerViewModel
            {
                CustomerID = customer.CustomerID,
                CompanyName = customer.CompanyName,
                ContactName = customer.ContactName,
                ContactTitle = customer.ContactTitle,
                Address = customer.Address,
                City = customer.City,
                Region = customer.Region,
                PostalCode = customer.PostalCode,
                Country = customer.Country,
                Phone = customer.Phone,
                Fax = customer.Fax,
                Bool = customer.Bool
            });
        }

        private static IEnumerable<OrderViewModel> GetOrders()
        {
            var northwind = new SampleEntities();

            return northwind.Orders.Select(order => new OrderViewModel
            {
                ContactName = order.Customer.ContactName,
                Freight = order.Freight,
                OrderDate = order.OrderDate,
                ShippedDate = order.ShippedDate,
                OrderID = order.OrderID,
                ShipAddress = order.ShipAddress,
                ShipCountry = order.ShipCountry,
                ShipName = order.ShipName,
                ShipCity = order.ShipCity,               
                EmployeeID = order.EmployeeID,
                CustomerID = order.CustomerID
            });
        }

        //private static IEnumerable<EmployeeViewModel> GetEmployees()
        //{
        //    var northwind = new SampleEntities();

        //    return northwind.Employees.Select(employee => new EmployeeViewModel
        //    {
        //        EmployeeID = employee.EmployeeID,
        //        FirstName = employee.FirstName,
        //        LastName = employee.LastName,
        //        Country = employee.Country,
        //        City = employee.City,
        //        Notes = employee.Notes,
        //        Title = employee.Title,
        //        Address = employee.Address,
        //        HomePhone = employee.HomePhone
        //    });
        //}


        public class CustomerViewModel
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public Nullable<bool> Bool { get; set; }
        }
    }
}