using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChecklistIO.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime FinishBy { get; set; }
    }
}
