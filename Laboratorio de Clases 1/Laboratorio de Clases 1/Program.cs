
using Class_BankAccount;
using CharacterCreator;
using EmployeeCreator;

class Program
{
    static void Main(string[] args)
    {
        /*BankAccount testing1 = new BankAccount();
        testing1.ShowBalance();
        testing1.Deposit();
        testing1.ShowBalance();
        testing1.Withdraw();
        testing1.ShowBalance();*/
        Character testing1 = new Character();
        testing1.ReceiveDamage();
        testing1.ShowStats();
        testing1.Heal();
        testing1.ShowStats();
        testing1.Heal();
        testing1.ReceiveDamage();
        
        Employee[] employees = new Employee[2];
        for (int i=0; i< employees.Length; i++)
        {
            employees[i] = new Employee();
        }
    }
}
