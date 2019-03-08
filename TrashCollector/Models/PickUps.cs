using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class PickUps
    {
        public string PickUpDay { get; set; }
        public string ExtraDay { get; set; }
        
        public DateTime? SuspendStart { get; set; }
        public DateTime? SuspendEnd { get; set; }
        public decimal CurrentCharges { get; set; }
    }
}