using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_BeginForm.Models
{
    public class tblFriend
    {
        [Key]
        public int FriendID { get; set; }
        public string FriendName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
    }
}