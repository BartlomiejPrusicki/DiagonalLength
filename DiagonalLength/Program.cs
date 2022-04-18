Console.WriteLine("Calculation of the diagonal length of a rectangle");

double a, b, diagonal;

Console.WriteLine("Enter page a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter page b");
b = double.Parse(Console.ReadLine());

diagonal = (System.Math.Pow(a, 2) + System.Math.Pow(b, 2));
Console.WriteLine("Diagonal has " + System.Math.Sqrt(diagonal));

Console.Read();