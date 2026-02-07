/* 1.- Arreglos
int[] folios = [10,14,101,105,801,1607,2034,5607];
bool existenceOfFolio = false;
int readFolio = 0;
int i = 0;
Console.WriteLine("Escriba el folio que quiera buscar \n");
readFolio = int.Parse(Console.ReadLine());
while (existenceOfFolio == false && i < folios.Length)
{
    if (folios[i] == readFolio)
    {
        existenceOfFolio = true;
    }
    else
    {
        i++;
    }
}

if (existenceOfFolio == true) 
{
    Console.WriteLine("El folio es valido \n");
}
else
{
    Console.WriteLine("El folio no es valido \n");
}
*/
// 2.- Matrices
int[] num = new int[10];

Console.WriteLine("Escriba 10 numeros enteros \n");
for (int i = 0; i < num.Length; i++)
{
    num[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Escriba el siguiente numero \n");
}

for (int i = 1; i <= 3 ; i++)
{
    for (int j = 0; j < num.Length; j++)
    {
        int result = (int)Math.Pow(num[j], i);
        Console.Write( result +" ");
    }
    Console.WriteLine();
}