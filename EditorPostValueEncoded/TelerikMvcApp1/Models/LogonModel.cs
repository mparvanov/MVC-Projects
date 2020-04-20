using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelerikMvcApp1.Models
{
    public class LogonModel
    {
		[Required]
		[Display(Name = "User name")]
		public string UserName { get; set; }

		
	}
}