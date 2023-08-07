// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координату xA");
int xA=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату yA");
int yA=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату zA");
int zA=int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координату xB");
int xB=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату yB");
int yB=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату zB");
int zB=int.Parse(Console.ReadLine());

double S=Math.Sqrt(Math.Pow(zB-zA,2)+Math.Pow(yB-yA,2)+Math.Pow(xB-xA,2));

System.Console.WriteLine($"Расстояние между точкой В и А составляет {S}");

