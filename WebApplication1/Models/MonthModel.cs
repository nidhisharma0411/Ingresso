using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MonthModel
    {
        public string Month { get; set; }
        public string Month_Short_Desc { get; set; }
        public string Month_Desc { get; set; }
        public string Month_Dates_Bitmask { get; set; }
        public long Month_Weekdays_Bitmask { get; set; }
        public long Year { get; set; }
    }
}
