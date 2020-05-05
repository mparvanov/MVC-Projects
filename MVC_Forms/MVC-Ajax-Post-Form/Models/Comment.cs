using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Ajax_Post_Form.Models
{
    public class Comment
    {
        public string CommentText { get; set; }
        public DateTime? DateCreated { get; set; }
        public long PostId { get; set; }
        public string UserName { get; set; }
    }
}