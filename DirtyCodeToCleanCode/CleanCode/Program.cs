namespace CleanCode;

class Program
{
    static void Main(string[] args)
    {
       
        List<TimeSheetEntry> timeSheetEntries = loadEntries();

        double totalHours = 0;

        var companies = new List<Company>()
        {
            new(){ Name="acme", HourlyPrice=150},
            new(){ Name="abc", HourlyPrice=125},

        };

        simulateMails(companies, timeSheetEntries);


        totalHours = 0;
        for (int i = 0; i < timeSheetEntries.Count; i++)
        {
            totalHours += timeSheetEntries[i].HoursWorked;
        }
        if (totalHours > 40)
        {
            Console.WriteLine("You will get paid $" + (((totalHours - 40) * 15) + (40 * 10)) + " for your work.");
        }
        else
        {
            Console.WriteLine("You will get paid $" + (totalHours * 10) + " for your time.");
        }
        Console.WriteLine();
        Console.Write("Press any key to exit application...");
        Console.ReadKey();
    }

    static void simulateMails(List<Company> companies, List<TimeSheetEntry> timeSheetEntries)
    {
        foreach (var company in companies)
        {
            var totalAmount = getBillAmountForCompany(company, timeSheetEntries);
            Console.WriteLine($"Simulating Sending email to {company.Name}");
            Console.WriteLine($"Your bill is $ {totalAmount}  for the hours worked.");
        }
    }

    static double getBillAmountForCompany(Company company, List<TimeSheetEntry> timeSheetEntries) 
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

           

        } while (answer.ToLower() ==Answers.YES);


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

public class Answers
{
    public const string YES = "yes";
    public const string NO = "no";
}

public class TimeSheetEntry
{
    public string WorkDone;
    public double HoursWorked;
}

