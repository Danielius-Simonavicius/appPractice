using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPractice;

internal class Employee
{
    public string firstName;
    public string lastName;
    private string email;
    private int numberOfHoursWorked;
    private double wage;
    private double hourlyRate;
    public DateTime birthday;

    const int minimalHoursWorkedUnit = 1;

    //constructor 
    public Employee(string first, string last, string em, DateTime bd, double? rate)
    {
        firstName = first;
        lastName = last;
        email = em;
        birthday = bd;
        
        
        
        
        
        
        
        
        
        
        hourlyRate = rate ?? 10;
    }

    public double? HourlyRate
    {
        get { return hourlyRate; }
        set 
        {
            if(hourlyRate < 0){ //added validation logic to make sure wage cannot be set to minus values
                hourlyRate = 0;
            }
            else{
                hourlyRate = (double) value;
            }
        }
    }

    public void PerformWork()
    {
        PerformWork(minimalHoursWorkedUnit);
        // Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
    }
    public void PerformWork(int numberOfHours)
    {
        numberOfHoursWorked += numberOfHours;
        Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
    }

    public double RecieveWage(bool resetHours = true)
    {
        wage = numberOfHoursWorked * hourlyRate;
        Console.WriteLine($"{firstName} {lastName} has recieved a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");
        if (resetHours)
        {
            numberOfHoursWorked = 0;
        }
        return wage;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail:\t\t{email}Birthday: \t{birthday.ToShortDateString()}\n");
    }
}
