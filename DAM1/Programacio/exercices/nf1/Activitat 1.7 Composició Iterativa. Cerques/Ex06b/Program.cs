using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace Ex06b
{
    /// <summary>
    /// Escriu la funció public static bool EsPrimer(int n) que retorna true si n és un número
    /// primer i seguidament, reescriu el programa 6a usant la funció
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introdueix un valor per saber si es primari");
            int numeroTeclat = Convert.ToInt32(Console.ReadLine());

            if (EsPrimer(numeroTeclat))
                Console.WriteLine($"{numeroTeclat} es un numero primari");
            else
                Console.WriteLine($"{numeroTeclat} no es un numero primari");

        }

        static bool EsPrimer(int n)
        {
            int cont = 0;
            int contbucle = 2;

            while (contbucle != n / 2 && cont != 1)
            {
                if (n % contbucle == 0) cont++;
                contbucle++;
            }

            return cont == 0;
        }
    }
}
