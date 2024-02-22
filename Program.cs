namespace appPractice
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello world");

            List<Employee> employees = new List<Employee>();
            Employee Dorian = new Employee("Dorian", "Kulakowski", "doriano2008@gmail.com", new DateTime(2004, 8, 15), 12, EmployeeType.Manager); //minimumwage wroker
            Employee Mehir = new Employee("Mehir", "Hossin", "mehirtalukdar2017@gmail.com", new DateTime(2003, 12, 5), 10, EmployeeType.TechSupport);
            Employee Danielius = new Employee("Danielius", "Simonavicius", "daniel@theguy.xyz", new DateTime(2004, 8, 10), 12, EmployeeType.TechSupport);
            Employee Mark = new Employee("Mark", "Richie", "markRichie@gmail.com", new DateTime(1945, 12, 1), 15, EmployeeType.Dad);

            employees.Add(Dorian);
            employees.Add(Mehir);
            employees.Add(Danielius);
            employees.Add(Mark);

            //Employee highestHourlyRateEmployee = employees.OrderByDescending(x => 20>x.HourlyRate).FirstOrDefault(); //learning lambda expression x=>
            //Console.WriteLine($"highest paid employee is {highestHourlyRateEmployee}");

            Dorian.HourlyRate = 50;

            int minimumBonus = 100;
            int bonusTax;
            int recievedBonus = Mehir.CalculateBonusAndTax(minimumBonus, out bonusTax);

            Dorian.PerformWork();
            Dorian.PerformWork();
            Dorian.PerformWork();
            Dorian.firstName = "Bethany";
            Dorian.HourlyRate = 14; // blud got a promotion

            double bonus = Mehir.CalculateBonusAndTax(5000,out bonusTax);

            // Dorian.DisplayEmployeeDetails();
            // Danielius.DisplayEmployeeDetails();
            // Mehir.DisplayEmployeeDetails();
            // Mark.DisplayEmployeeDetails();

        }

        public static int addNumbers(out int a, out int b)
        {
            a = 55;
            b = 55;
            int result = a + b;
            return result;
        }
    }
}