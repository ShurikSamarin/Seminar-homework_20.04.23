// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input first number");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number");
int number_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Input third number");
int number_3 = int.Parse(Console.ReadLine());
int max = number_1;
if(number_2 > max)
{
    max = number_2;
}
if(number_3 > max)
{
    max = number_3;
} 
Console.WriteLine("Max number = " + max);
