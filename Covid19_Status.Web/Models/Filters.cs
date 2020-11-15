using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covid19_Status.Web.Models
{
    public class Filters
    {
        public string Country { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}