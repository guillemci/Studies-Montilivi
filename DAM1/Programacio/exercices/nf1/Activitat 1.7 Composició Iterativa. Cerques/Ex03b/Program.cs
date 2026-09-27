using System;
using System.Runtime.ConstrainedExecution;

namespace Ex03b
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, indicar si hi ha algun número parell.
        /// b. Versió 2: La seqüència prové del teclat i acaba amb -9999.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("introdueix numeros per anar mirant quins son parells, el programa es parara quan detecti el -9999");
            int Numero = Convert.ToInt32(Console.ReadLine());
            bool trobat = false;

            while (Numero != -9999 && !trobat)
            {
                Numero = Convert.ToInt32(Console.ReadLine());
                trobat = Numero % 2 == 0;
            }

            if (trobat) Console.WriteLine($"a la linea numero: {Numero} s'ha trovat un numero parell");
            else Console.WriteLine("no s'ha trovat cap numero parell");
        }
    }
}
 