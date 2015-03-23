using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CardSharkWebApp.Models
{
    public class Prediction
    {
        public int ID { get; set; }

        public string UserID { get; set; }

        public string Guess { get; set; }

        public int MatchID { get; set; }

        [JsonIgnore]
        public virtual Match Match { get; set; }
    }
}