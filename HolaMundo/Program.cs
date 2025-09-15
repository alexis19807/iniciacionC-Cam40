// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");

//DESAFIO Ejercicio: Realización de una actividad de desafío con el ámbito de las variables

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
       found = true;
    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");
