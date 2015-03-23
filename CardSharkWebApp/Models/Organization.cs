using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CardSharkWebApp.Models
{
    public class Organization
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Event> Events { get; set; }
    }
}