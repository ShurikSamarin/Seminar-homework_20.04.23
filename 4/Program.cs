// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine());
int counter = 1;
while (counter < number)
{
    Console.Write(counter+1);
    Console.Write(" ");
    counter = counter + 2;
}
Console.WriteLine(" ");
