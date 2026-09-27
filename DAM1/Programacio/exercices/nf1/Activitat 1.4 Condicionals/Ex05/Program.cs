namespace Ex05
{
    internal class Program
    {
        /// <summary>
        /// Us proposem funcions en negreta cursiva per resoldre la part de càlcul.
        ///5. Feu un programa que et demani un nombre enter per teclat i t'informo:
        ///● Si és parell o senar
        ///● Si és múltiple de 7 o no ho és.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int numero;
            string resultatReturn;

            //inicialitzacio variable
            Console.WriteLine("Entra el nombre i et dirè si es perell o senar i si es multiple de 7 o no");
            numero = Convert.ToInt32(Console.ReadLine());

            //calcul dints funcio
            resultatReturn = RevisioNumero(numero);

            //output
            Console.WriteLine(resultatReturn);
        }
        static string RevisioNumero(int numero)
        {
            //variable
            string resultatParell;
            string resultatMultiple;
            string resultatFinal;

            //condicional
            if (numero % 2 == 0)
            {
                resultatParell = ("es parell");
            }
            else
            {
                resultatParell = ("es imparell");
            }

            if (numero % 7 == 0)
            {
                resultatMultiple = ("es multiple de 7");
            }
            else
            {
                resultatMultiple = ("no es multiple de 7");
            }

            return resultatFinal = ($"el numero introduit {numero} {resultatParell} i {resultatMultiple}");
        }
    }
}
