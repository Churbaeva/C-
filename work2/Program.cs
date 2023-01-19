// See https://aka.ms/new-console-template for more information
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int maximum = (Math.Max(number1, Math.Max(number2, number3)));
System.Console.WriteLine(maximum);