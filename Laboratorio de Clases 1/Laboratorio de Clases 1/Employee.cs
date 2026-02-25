namespace EmployeeCreator;

public class Employee
{
    public string name;
    public string category;
    public int id;
    public float salary;
    public float salarySum;

    public void Employee()
    {
        name = Console.ReadLine();
        category = Console.ReadLine();
        id = int.Parse(Console.ReadLine());
        salary = float.Parse(Console.ReadLine());
    }

    public float Salary()
    {
        for (int i = 0; i < 3; i++)
        {
            salarySum = Employee[i].salary + salarySum;
        }
    }
}