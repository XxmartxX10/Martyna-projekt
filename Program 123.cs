// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double a, b, tmp;
Console.Write("podaj wartość zmiennej a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("podaj wartość zmiennej b: ");
b = Convert.ToDouble(Console.ReadLine());
tmp = a;
a = b;
b = tmp;
// Console.WriteLine("a = " + a + ", b = " + b);
Console.WriteLine("a = {0}, b = {1}", a, b);
Console.ReadKey();