using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            var weekEndList = new List<DateTime>();
            if (weekEnds != null)
            {
                foreach (var day in weekEnds)
                {
                    DateTime currWeekEnd = day.StartDate;
                    while (currWeekEnd <= day.EndDate)
                    {
                        weekEndList.Add(currWeekEnd);
                        currWeekEnd = currWeekEnd.AddDays(1);
                    }

                }
            }

            var result = startDate;
            var counter = 0;
            while (counter < dayCount)
            {
                if (!weekEndList.Contains(result))
                {
                    counter += 1;
                    if (counter == dayCount) break;
                    result = result.AddDays(1);
                }
                else
                {
                    result = result.AddDays(1);
                }
            }

            return result;
        }
    }
}