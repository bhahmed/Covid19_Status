using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_Status.Models
{
    public class CovidStatus
    {
        public string Country { get; set; }

        public int Confirmed { get; set; }

        public int Deaths { get; set; }

        public int Recovered { get; set; }

        public int Active { get; set; }

        public DateTime Date { get; set; }
    }
}
