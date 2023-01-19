// See https://aka.ms/new-console-template for more information
Console.WriteLine("insert the number");
int number = Convert.ToInt32(Console.ReadLine());
for (int currentNumber = 2; currentNumber<=number; currentNumber +=2)
{
    System.Console.WriteLine(currentNumber + "");
}
