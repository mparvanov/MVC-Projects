using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelerikMvcApp1.Models
{
    public class ProductViewModel
    {
        [ScaffoldColumn(false)]
        public int ProductID
        {
            get;
            set;
        }

        [Required]
        [DisplayName("Product name")]
        [Remote("IsProductName_Available", "Validation")]
        public string ProductName
        {
            get;
            set;
        }

        [DisplayName("Unit price")]
        [DataType(DataType.Currency)]
        [Range(0, int.MaxValue)]
        public decimal UnitPrice
        {
            get;
            set;
        }

        [DisplayName("Units in stock")]
        [DataType("Integer")]
        [Range(0, int.MaxValue)]
        public int UnitsInStock
        {
            get;
            set;
        }

        public bool Discontinued
        {
            get;
            set;
        }

        [DisplayName("Last supply")]
        [DataType(DataType.Date)]
        public DateTime LastSupply
        {
            get;
            set;
        }

        [DataType("Integer")]
        public int UnitsOnOrder
        {
            get;
            set;
        }

        [UIHint("ClientCategory")]
        public CategoryViewModel Category
        {
            get;
            set;
        }

        public int? CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }
    }

    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}