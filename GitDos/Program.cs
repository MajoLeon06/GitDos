Console.WriteLine("Ingrese número de 1 a 10");
int number = int.Parse(Console.ReadLine());
if (number>0)
{
    if (number==1)
    {
        Console.WriteLine("Bienvenido");
    }
    if (number>1 && number <9)
    {
        Console.WriteLine("Opciones múltiples");
    }
    else
    {
        Console.WriteLine("Salida, esperamos que vuelva pronto");
    }
}
else
{
    Console.WriteLine("Error");
}