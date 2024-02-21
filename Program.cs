namespace appPractice
{
    class Program
    {
        static void Main(String[] args){
            Console.WriteLine("Hello world");

            Employee Bethany = new Employee("Bethany","Smith","bethanySmith@email.com", new DateTime (1979, 1,16) , 25);

            Bethany.DisplayEmployeeDetails();
        }
    }
}