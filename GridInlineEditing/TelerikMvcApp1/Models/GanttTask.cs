//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelerikMvcApp1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GanttTask
    {
        public GanttTask()
        {
            this.GanttTasks1 = new HashSet<GanttTask>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public int OrderID { get; set; }
        public string Title { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime End { get; set; }
        public decimal PercentComplete { get; set; }
        public bool Expanded { get; set; }
        public bool Summary { get; set; }
    
        public virtual ICollection<GanttTask> GanttTasks1 { get; set; }
        public virtual GanttTask GanttTask1 { get; set; }
    }
}