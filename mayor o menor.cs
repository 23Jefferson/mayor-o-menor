sing System;

namespace MayorYMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparador de Números Mayor y Menor");
            Console.WriteLine("===================================");

            Console.Write("Ingrese el primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double numero3 = double.Parse(Console.ReadLine());

            double mayor = Math.Max(numero1, Math.Max(numero2, numero3));
            double menor = Math.Min(numero1, Math.Min(numero2, numero3));

            Console.WriteLine($"El número mayor es: {mayor}");
            Console.WriteLine($"El número menor es: {menor}");
        }
    }
}