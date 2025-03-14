// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número, por favor");
int numero;
if (int.TryParse(Console.ReadLine(), out numero))
{
    if (numero % 2 == 0)
    {
        Console.WriteLine($"El Numero es par.");
    }
    else
    {
        Console.WriteLine($"El Numero  es impar.");
    }
}
else
{
    Console.WriteLine("Entrada no valida");
}

