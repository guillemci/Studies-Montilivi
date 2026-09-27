using System.Drawing;

namespace Ex05
{
    internal class Program
    {
        /// <summary>
        /// Es considera que qualsevol nombre enter positiu n és perfecte si la suma dels seus divisors,
        /// excepte ell mateix, és igual a n.Per exemple, 6 és perfecte, ja que 6=1+2+3
        /// a.Donat un valor enter positiu introduït pel teclat, indicar si és perfecte o no.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("introdueix aqui el numero per veure si es perfecte o no");
            int valorTeclatPrimer = Convert.ToInt32(Console.ReadLine());
            int contador = 1;
            int acomulador = 0;
            bool passat = false, final = false;

            while (!passat && !final)
            {
                if (valorTeclatPrimer % contador == 0)
                    acomulador += contador;

                passat = valorTeclatPrimer <= acomulador;
                final = contador >= valorTeclatPrimer / 2;

                contador++;
            }

            if (acomulador == valorTeclatPrimer)
                Console.WriteLine($"el numero {valorTeclatPrimer} es tracta d'un numero perfecte");
            else
                Console.WriteLine($"el numero {valorTeclatPrimer} no es tracta d'un numero perfecte");
        }
    }
}
