// See https://aka.ms/new-console-template for more information
int num1;
Console.WriteLine("Escriba el número");
num1 = int.Parse(Console.ReadLine());
bool pairOrImpair(int num1)
{
    if (num1 % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

if (pairOrImpair(num1))
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}