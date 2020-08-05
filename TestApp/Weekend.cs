using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class WeekEnd
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public WeekEnd(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}