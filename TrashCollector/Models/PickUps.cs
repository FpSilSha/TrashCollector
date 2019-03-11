using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class PickUps
    {
        [Key]
        public int Id { get; set; }
        public string PickUpDay { get; set; }
        public string ExtraDay { get; set; }
        
        public DateTime? SuspendStart { get; set; }
        public DateTime? SuspendEnd { get; set; }
        public decimal CurrentCharges { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}