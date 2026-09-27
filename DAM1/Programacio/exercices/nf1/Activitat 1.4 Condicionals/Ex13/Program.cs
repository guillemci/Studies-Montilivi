namespace Ex13
{
    internal class Program
    {
        ///<summary>
        /// 13. Fes un programa per saber si un nombre enter de 3 xifres entrat per teclat és
        /// cap-i-cua.
        ///</summary>
        static void Main(string[] args)
        {
            //variable
            int numero;
            string resultatFinal;

            //inicialitzacio variable
            Console.WriteLine("proporciona un numero de 3 xifres per saber si es cap i cua");
            numero = Convert.ToInt32(Console.ReadLine());

            //calcul funcio
            resultatFinal = SaberSiEsCapICua(numero);

            //output
            Console.WriteLine(resultatFinal);
        }

        static string SaberSiEsCapICua(int numero_)
        {
            int numero1;
            int numero2;
            int numero3;
            string resultat;

            numero1 = numero_ / 100;
            numero2 = numero_ / 10 % 10;
            numero3 = numero_ % 10;

            //condicional
            if (numero_ > 999 || numero_ < 100)
            {
                resultat = ("proporciona un valor valid");
            }
            else if (numero1 == numero3)
            {
                resultat = ($"el numero proporcionar {numero_} es cap i cua");
            }
            else
            {
                resultat = ($"el numero proporcionar {numero_} no es cap i cua");
            }

            return resultat;
        }
    }
}
