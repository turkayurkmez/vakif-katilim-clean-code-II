using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Library
{
    public class MailService
    {
        private readonly ICalculatorService _calculatorService;

        public MailService(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public void SimulateMails(List<Company> companies, List<TimeSheetEntry> timeSheetEntries)
        {
            foreach (var company in companies)            {
             
                var totalAmount = _calculatorService.GetBillAmountForCompany(company, timeSheetEntries);
                Console.WriteLine($"Simulating Sending email to {company.Name}");
                Console.WriteLine($"Your bill is $ {totalAmount}  for the hours worked.");
            }
        }

     
    }
}
