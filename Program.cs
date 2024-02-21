namespace appPractice
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello world");

            List<Employee> employees = new List<Employee>();
            Employee Bethany = new Employee("Bethany", "Smith", "bethanySmith@email.com", new DateTime(1979, 1, 16),14,EmployeeType.Research);
            Employee John = new Employee("John", "Baily", "John12@email.com", new DateTime(2004, 8, 10),2590,EmployeeType.Manager);
            employees.Add(Bethany);
            employees.Add(John);

            //Employee highestHourlyRateEmployee = employees.OrderByDescending(x => 20>x.HourlyRate).FirstOrDefault(); //learning lambda expression x=>
            //Console.WriteLine($"highest paid employee is {highestHourlyRateEmployee}");

            Bethany.HourlyRate = 50;

            int minimumBonus = 100;
            int bonusTax;
            int recievedBonus = John.CalculateBonusAndTax(minimumBonus, out bonusTax);
            
            Bethany.PerformWork();
            Bethany.PerformWork();
            Bethany.PerformWork();

            Bethany.firstName = "Bethany";
            Bethany.HourlyRate = 10; // using property
            Bethany.RecieveWage();
            John.DisplayEmployeeDetails();
        }
    }
}