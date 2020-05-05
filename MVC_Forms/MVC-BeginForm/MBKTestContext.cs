using System;
using System.Collections.Generic;
using System.Data.Entity;
using MVC_BeginForm.Models;

using System.Linq;
using System.Web;

namespace MVC_BeginForm
{
    public class MBKTestContext : DbContext
    {
        public MBKTestContext() : base("MBKTest")
        {

        }
        public DbSet<tblFriend> Friends { get; set; }
    }  
}