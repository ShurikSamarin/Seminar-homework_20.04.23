// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine());
int Res = number%2;
//Console.WriteLine("RES = " + Res);
if(Res == 0)
{
    Console.WriteLine("Number is even-numbered");
}
else
{
    Console.WriteLine("Number is not even-numbered");
}
