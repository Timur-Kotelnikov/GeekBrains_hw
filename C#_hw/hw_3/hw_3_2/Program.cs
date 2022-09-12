// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
Console.WriteLine("First point (input 3 numbers separated by commas):");
string? inputLine1 = Console.ReadLine();
Console.WriteLine("Second point (input 3 numbers separated by commas):");
string? inputLine2 = Console.ReadLine();
if (inputLine1 != null && inputLine2 != null)
{
    string[] result1 = inputLine1.Split(",");
    int coordinate1x = int.Parse(result1[0]);
    int coordinate1y = int.Parse(result1[1]);
    int coordinate1z = int.Parse(result1[2]);
    string[] result2 = inputLine2.Split(",");
    int coordinate2x = int.Parse(result2[0]);
    int coordinate2y = int.Parse(result2[1]);
    int coordinate2z = int.Parse(result2[2]);
    double distance = Math.Sqrt(Math.Pow((coordinate1x-coordinate2x), 2) + Math.Pow((coordinate1y-coordinate2y), 2) + Math.Pow((coordinate1z-coordinate2z), 2));
    Console.WriteLine($"Distance = {distance}");
}
