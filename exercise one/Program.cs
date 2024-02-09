// See https://aka.ms/new-console-template for more information

int number1, number2;
Console.WriteLine("Write your first number: ");
number1 = int.Parse (Console.ReadLine());
Console.WriteLine(" Write your second number");
number2 = int.Parse(Console.ReadLine());

int sum;

sum = number1 + number2;

Console.WriteLine("Your answer is = " + sum);
Console.WriteLine("Thanks!!");
Console.ReadKey();