using System.Globalization;

//DESAFIO Ejercicio: Realización de una actividad de desafío con el ámbito de las variables
CultureInfo.CurrentCulture = new CultureInfo("en-US");

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

Console.Clear();
//Ejercicio: Realización de un desafío para combinar valores de matriz de cadenas como cadenas y como enteros

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal totalEjercicio = 0m;
string frase = String.Empty;

for (var i = 0; i < values.Length; i++)
{
    if (decimal.TryParse(values[i], out var value))
    {
        totalEjercicio += value;
    }
    else
    {
        frase += $"{values[i]}";
    }
}

Console.WriteLine($"Message: {frase}");
Console.WriteLine($"Total: {totalEjercicio}");