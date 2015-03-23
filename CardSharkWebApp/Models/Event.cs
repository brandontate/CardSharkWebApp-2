using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardSharkWebApp.Models
{
    public class Event
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int OrganizationID { get; set; }

        [JsonIgnore]
        public virtual Organization Organization { get; set; }

        public virtual List<Match> Matches { get; set; }
    }
}