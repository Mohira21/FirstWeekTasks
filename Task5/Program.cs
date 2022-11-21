
Console.WriteLine("Enter your number : ");

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
        Console.WriteLine(i);
}