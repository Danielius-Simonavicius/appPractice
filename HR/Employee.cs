using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPractice;

internal class Employee
{
    private string firstName;
    private string lastName;
    private string email;
    public int numberOfHoursWorked;
    public double wage;
    public double hourlyRate;
    public DateTime birthday;
    public bool sacked;
     public bool bonus;
    const int minimalHoursWorkedUnit = 1;

    //constructor 
    public Employee(string first, string last, string em, DateTime bd, double rate)
    {
        firstName = first;
        lastName = last;
        email = em;
        birthday = bd;
        hourlyRate = rate;
        sacked=false;
        bonus=false;
    }

    public void PerformWork()
    {
        numberOfHoursWorked++;
        Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
    }
    public void PerformWork(int numberOfHours)
    {
        numberOfHoursWorked += numberOfHours;
        Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
    }

    public void DisplayEmployeeDetails(){
        Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail:\t\t{email}Birthday: \t{birthday.ToShortDateString()}\n");
    }
    public void setIsFired()
    {
        this.sacked=sacked;
    }
     public void getBonus()
    {
        if(firstName.equals("Mark"))
        {
            this.bonus=true;
        }
    }
}
