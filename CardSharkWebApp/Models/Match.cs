using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CardSharkWebApp.Models
{
    public class Match
    {
        public int ID { get; set; }

        public string FirstOpponent { get; set; }

        public string SecondOpponent { get; set; }

        public string Winner { get; set; }

        public int EventID { get; set; }

        [JsonIgnore]
        public virtual Event Event { get; set; }
    }
}