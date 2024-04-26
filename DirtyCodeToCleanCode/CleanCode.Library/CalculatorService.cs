using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Library
{
    public class CalculatorService : ICalculatorService
    {
        public double GetBillAmountForCompany(Company company, List<TimeSheetEntry> timeSheetEntries)
        {
            double totalHours = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(company.Name.ToLower()))
                {
                    totalHours += timeSheetEntries[i].HoursWorked;
                }
            }
            return totalHours * company.HourlyPrice;
        }

        public double CalculateExtraPayment(int maxWeeklyWorkingHours, double extraPayment, double normalPayment, double totalHours)
        {
            double billAmount = 0.0;
            if (totalHours > maxWeeklyWorkingHours)
            {
                var extra = (totalHours - maxWeeklyWorkingHours) * extraPayment;
                var normal = maxWeeklyWorkingHours * normalPayment;
                billAmount = normal + extra;
            }
            else
            {
                billAmount = totalHours * normalPayment;
            }

            return billAmount;
        }

        public double GetTotalHours(List<TimeSheetEntry> timeSheetEntries)
        {
            double totalHours = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                totalHours += timeSheetEntries[i].HoursWorked;
            }

            return totalHours;
        }
    }
}
