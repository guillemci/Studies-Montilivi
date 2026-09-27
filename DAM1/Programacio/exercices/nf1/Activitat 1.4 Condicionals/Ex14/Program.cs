namespace Ex14
{
    internal class Program
    {
        /// <summary>
        /// 14. Fes un altre programa per saber si un nombre enter de 4 xifres és cap-i-cua.
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            int numero;
            string resultat;

            //inicialitzacio variable
            Console.WriteLine("proporciona un numero de 4 digitis");
            numero = Convert.ToInt32(Console.ReadLine());

            //calcul funcio
            resultat = MirarSiNumeroEsCapICua(numero);

            //output
            Console.WriteLine(resultat);
        }

        static string MirarSiNumeroEsCapICua(int numero_)
        {
            int numero1;
            int numero2;
            int numero3;
            int numero4;
            string resultat;

            //condicional
            numero1 = numero_ / 1000;
            numero2 = numero_ / 100 % 10;
            numero3 = numero_ % 100 / 10;
            numero4 = numero_ % 10;

            if (numero_ > 9999 || numero_ < 1000)
            {
                resultat = ($"introdueix un valor valid");
            }
            else if ((numero1 == numero4 && numero2 == numero3))
            {
                resultat = ($"el numero proporcionat {numero_} es cap i cua");
            }
            else
            {
                resultat = ($"el numero proprocionat {numero_} no es cap i cua");
            }

            return resultat;
        }
    }
}