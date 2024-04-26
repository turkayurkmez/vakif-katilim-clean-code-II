
namespace CleanCode.Library
{
    public interface ICalculatorService
    {
        double CalculateExtraPayment(int maxWeeklyWorkingHours, double extraPayment, double normalPayment, double totalHours);
        double GetBillAmountForCompany(Company company, List<TimeSheetEntry> timeSheetEntries);
        double GetTotalHours(List<TimeSheetEntry> timeSheetEntries);
    }
}