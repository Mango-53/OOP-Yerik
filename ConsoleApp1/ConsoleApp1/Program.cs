// See https://aka.ms/new-console-template for more information
using System;
    
int num;
int table;

num = int.Parse(Console.ReadLine());
    Console.WriteLine("Escribe el número a multiplicar");
for (int i = 0; i < 10; i++)
{
    table=num*(i+1);
    Console.WriteLine(table);
}