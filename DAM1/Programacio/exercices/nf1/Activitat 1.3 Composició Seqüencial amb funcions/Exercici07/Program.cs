namespace Exercici07
{
    internal class Program
    {
        /// <summary>
        /// Demana a l'usuari que introdueixi un número enter (suposarem que l’usuari
        ///sempre entra un numero enter de 4 digits) i el programa ens ha de dir quant sumen
        ///els seus digits.Per exemple, si l’usuari entra 1234 el programa ha de mostrar:
        ///Els digits 1234 sumen 10. Per fer-ho, dissenyeu una funció que rebi un enter
        ///(suposarem que l’enter sempre té 4 dígits) i que retorni un altre enter
        ///corresponent a la suma dels seus digits.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int digitEnter;
            int resultatSuma;

            //inicialitzacio
            Console.WriteLine("introdueix aqui un numero de 4 digits:");
            digitEnter = Convert.ToInt32(Console.ReadLine());

            //calcul amb funcio
            resultatSuma = DivisioISumaDigits(digitEnter);

            //output
            Console.WriteLine($"Els digits {digitEnter} sumen {resultatSuma}");
        }

        //funcio
        static int DivisioISumaDigits(int digitenter)
        {
            int digit1 = digitenter / 1000;
            int digit2 = (digitenter / 100) % 10;
            int digit3 = (digitenter / 10) % 10;
            int digit4 = digitenter % 10;

            int sumaDigits = digit1 + digit2 + digit3 + digit4;
            return sumaDigits;
        }
    }
}