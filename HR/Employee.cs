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
    public bool sacked = false;
    private bool bonus;
    const int minimalHoursWorkedUnit = 1;

    public EmployeeType employeeType;
    //default constructor 

    public Employee(string first, string last, string em, DateTime bd) : this(first,
    last, em, bd, 0, EmployeeType.StoreManager)
    {

    }

    //general constructor 
    public Employee(string first, string last, string em, DateTime bd, double? rate,
    EmployeeType empType)
    {
        firstName = first;
        lastName = last;
        email = em;
        birthday = bd;
        sacked = false;
        bonus = false;
        HourlyRate = rate ?? 10;
        employeeType = empType;
    }

    public void PerformWork()
    {
        PerformWork(minimalHoursWorkedUnit);
    }
    public void PerformWork(int numberOfHours)
    {
        numberOfHoursWorked += numberOfHours;
        Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");

        // Console.WriteLine($"dorians name is {firstName} and his last name is {lastName}");
    }


    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail:\t\t{email}Birthday: \t{birthday.ToShortDateString()}\n");
    }


    public double HourlyRate
    {
        get { return hourlyRate; }
        
        set
        {
            if (hourlyRate < 0)
            { //added validation logic to make sure wage cannot be set to minus values
                hourlyRate = 0;
            }
            else
            {
                hourlyRate = value;
            }
        }
    }

    public void setIsFired()
    {
        sacked = true;
    }
    public int CalculateBonusAndTax(int bonus, out int bonusTax)
    {
        bonusTax = 0;
        if (numberOfHoursWorked > 10)
        {
            bonus *= 2;
        }
        if (bonus >= 200)
        {
            bonusTax = bonus / 10;
            bonus -= bonusTax;
        }

        Console.WriteLine($"{firstName} got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
        return bonus;
    }

    public double RecieveWage(bool resetHours = true)
    {

        if (employeeType == EmployeeType.StoreManager)
        { 
            wage = numberOfHoursWorked * 1.25;
            Console.WriteLine($"An extra was added to the wage since {firstName} is a manager");
        }
        else
        {
            wage = numberOfHoursWorked * hourlyRate;
        }

        Console.WriteLine($"{firstName} {lastName} has recieved a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");
        if (resetHours)
        {
            numberOfHoursWorked = 0;
        }
        return wage;
    }
}
