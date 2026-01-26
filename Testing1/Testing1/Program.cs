// See https://aka.ms/new-console-template for more information

int area, sideA, sideB, height;

height = int.Parse(Console.ReadLine());
sideA = int.Parse(Console.ReadLine());
sideB = int.Parse(Console.ReadLine());

area = height*sideA*sideB;
Console.WriteLine("The result is: " + area);
