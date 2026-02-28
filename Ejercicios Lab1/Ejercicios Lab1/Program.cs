using Class_BankAccount;
using CharacterCreator;
using EmployeeCreator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inicia BankAccount");
        
        BankAccount testing1 = new BankAccount();
        testing1.ShowBalance();
        testing1.Deposit();
        testing1.ShowBalance();
        testing1.Withdraw();
        testing1.ShowBalance();
        
        Console.WriteLine("Inicia character");
        
        Character testing2 = new Character();
        testing2.ReceiveDamage();
        testing2.ShowStats();
        testing2.Heal();
        testing2.ShowStats();
        testing2.Heal();
        testing2.ReceiveDamage();
        
        Console.WriteLine("Cuantos empleados");
        int number = int.Parse(Console.ReadLine());
        
        Employee[] employees = new Employee[number];
        
        for (int i=0; i < number; i++)
        {
            employees[i] = new Employee();
        }
        
        Employee.AverageSalary(employees);
    }
}