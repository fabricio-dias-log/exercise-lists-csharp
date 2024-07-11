using System.Globalization;

namespace ExerciseLists;

class Program
{
    static void Main(string[] args)
    {
        int option;
        List<Employee> employees = new List<Employee>();
        Employee employee;
        
        Console.Write("How many employees do you want to register: ");
        int qtiEmployee = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Employee register:");
        Console.WriteLine("-----------------------------");

        for (int i = 0; i < qtiEmployee; i++)
        {
            Console.Write("Employee id: ");
            int employeeId = int.Parse(Console.ReadLine());
            Console.Write("Employee name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Do you want to set a employee salary?(y/n): ");
            string salaryOption = Console.ReadLine();
            if (salaryOption == "y" || salaryOption == "yes")
            {
                Console.Write("Employee salary: ");
                double employeeSalary = double.Parse(Console.ReadLine());
                employee = new Employee(employeeId, employeeName, employeeSalary);
            }
            else
            {
                employee = new Employee(employeeId, employeeName);
            }
            
            employees.Add(employee);
        }
        
        do
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - List employees");
            Console.WriteLine("2 - Increase a salary");
            Console.WriteLine("-----------------------------");
            Console.Write("Opção: ");

            option = int.Parse(Console.ReadLine());
            
            Console.Clear();

            switch (option)
            {
                case 1:
                    foreach (var employeeData in employees)
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine($"Id: {employeeData.Id}");
                        Console.WriteLine($"Name: {employeeData.Name}");
                        Console.WriteLine($"Salary: R${employeeData.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    break;
                case 2:
                    Console.Write("Write which employee do you want to increase a salary: ");
                    int employeeId = int.Parse(Console.ReadLine());
                    
                    Employee ?selectedEmployee = employees.Find(x => x.Id == employeeId) ?? null;

                    if (selectedEmployee != null)
                    {
                        Console.Write("How many do you want to increase: ");
                        double valueToIncrease = double.Parse(Console.ReadLine());
                    
                        selectedEmployee.IncreaseSalary(valueToIncrease);
                    }
                   
                    break;
                default:
                    return;
            }

        } while (true);
    }
}