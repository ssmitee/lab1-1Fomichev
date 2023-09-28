Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
double F = Math.Cos(x * x + 2) + (3.5 * (x * x))/(Math.Pow(Math.Cos(y), 2));
Console.WriteLine($"F={F:F2}");