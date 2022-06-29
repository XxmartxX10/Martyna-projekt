// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] imiona = { "Piotr", "Anna", "Jan", "Leszek" };
for (int i = 0; i < imiona.Length; i++)
{
    Console.WriteLine(i + 1 + ". " + imiona[i]);
}

Console.ReadLine();
