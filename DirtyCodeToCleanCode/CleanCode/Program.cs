using CleanCode.Library;

namespace CleanCode;

class Program
{
    static void Main(string[] args)
    {
        List<TimeSheetEntry> timeSheetEntries = loadEntries();
        double totalHours = 0;
        InMemoryCompanyRepository inMemoryCompanyRepository = new InMemoryCompanyRepository();
        CompanyService companyService = new CompanyService(inMemoryCompanyRepository);
        CalculatorService calculator = new CalculatorService();
        MailService mailService = new MailService(calculator);
       
        var companies = companyService.GetCompanies();
        mailService.SimulateMails(companies, timeSheetEntries);
        
        totalHours = calculator.GetTotalHours(timeSheetEntries);
        var billAmount = calculator.CalculateExtraPayment(maxWeeklyWorkingHours: 40, extraPayment: 15, normalPayment: 10, totalHours: totalHours);
        Console.WriteLine($"Your bill is: $ {billAmount}");
        Console.WriteLine();
        Console.Write("Press any key to exit application...");
        Console.ReadKey();
    }

    private static List<TimeSheetEntry> loadEntries()
    {

        var timeSheetEntries = new List<TimeSheetEntry>();
        string answer = string.Empty;
        do
        {
            double timeForWork;
            Console.Write("Enter what you did: ");
            string workDone = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            string rawTimeWorked = Console.ReadLine();

            timeForWork = getTimeForWorkFromUser(rawTimeWorked);

            TimeSheetEntry timeSheetEntry = new TimeSheetEntry
            {
                HoursWorked = timeForWork,
                WorkDone = workDone
            };
            timeSheetEntries.Add(timeSheetEntry);
            Console.Write("Do you want to enter more time (yes/no): ");
            answer = Console.ReadLine();



        } while (answer.ToLower() == Answers.YES);

        return timeSheetEntries;

    }
    private static double getTimeForWorkFromUser(string rawTimeWorked)
    {
        double timeForWork;
        while (double.TryParse(rawTimeWorked, out timeForWork) == false)
        {
            Console.WriteLine();
            Console.WriteLine("Invalid number given");
            Console.Write("How long did you do it for: ");
            rawTimeWorked = Console.ReadLine();
        }

        return timeForWork;
    }
}


