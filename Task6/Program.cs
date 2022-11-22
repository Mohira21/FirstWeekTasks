

Console.WriteLine("Enter your number : ");

int n = int.Parse(Console.ReadLine());


Console.WriteLine("Whould you like to compute the sum or compute th product? \n " +
    "for compute the sum choose 1, " +
    "for compute th product choose 2");

int choose = int.Parse(Console.ReadLine());

if (choose == 1)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum += i;
    Console.WriteLine(sum);
}
if (choose == 2)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum *= i;
    Console.WriteLine(sum);
}
else Console.WriteLine("incorrect choice");