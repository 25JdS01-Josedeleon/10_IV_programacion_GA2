internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*********************");
        Console.WriteLine("*** Menu de opciones ***");
        Console.WriteLine("*********************");
        int opc, num1, num2;
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("Ingrese una opción: ");
        opc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese una opcion: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el primer numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");

        switch (opc)
        {
            case 1:
                Console.WriteLine("La suma es: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("La resta es: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("La multiplicación es: " + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("La división es: " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
        }
}