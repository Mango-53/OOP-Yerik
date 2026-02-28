namespace EmployeeCreator;

public class Employee
{
    public string name;
    public string category;
    public int id;
    public float salary;

    public Employee()
    {
        Console.WriteLine("Write the name of the employee \n");
        name = Console.ReadLine();
        
        Console.WriteLine("Write the Category of the employee \n");
        category = Console.ReadLine();
        
        Console.WriteLine("Write the id of the employee \n");
        id = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Write the Salary of the employee \n");
        salary = float.Parse(Console.ReadLine());
    }

    public static void AverageSalary(Employee[] employees)
    {
        float salarySum=0;
        foreach (Employee emp in employees)
        {
            salarySum += emp.salary;
        }
        float salaryAve = salarySum/employees.Length;
    
        Console.WriteLine($"Average Salary: {salaryAve}\n");
        foreach (Employee emp in employees)
        {
            if (emp.GetSalary() < salaryAve)
            {
                Console.WriteLine(emp.GetName());
            }
        }
    }

    public float GetSalary()
    {
        return salary;
    }

    public string GetName()
    {
        return name;
    }
}