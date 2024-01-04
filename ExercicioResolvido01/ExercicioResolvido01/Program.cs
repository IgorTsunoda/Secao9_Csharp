using ExercicioResolvido01.Entities.Enums;
using ExercicioResolvido01.Entities;
using System.Globalization;

namespace ExercicioResolvido01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department's name: ");
            string departmentName = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("Enter worker data:");

            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());

            Department dpt = new Department(departmentName);
            Worker worker = new Worker(name, level, salary, dpt);

            Console.Write("How many contracts to this worker? ");
            int nContract = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nContract; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours= int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ":" + worker.Income(year, month));
        }
    }
}