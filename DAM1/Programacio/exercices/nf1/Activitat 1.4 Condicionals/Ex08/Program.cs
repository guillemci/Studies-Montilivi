namespace Ex8
{
    internal class Program
    {
        /// <summary>
        /// 8. Valideu d’una hora en format 24 hores: Feu un programa que pregunti una hora en
        ///format de 24 hores i que ens digui si aquesta és correcta o no.Cal introduïr un sol enter
        ///en format hhmmss.
        ///Per exemple, el número 153045 és correcte, però el número 250000 no és correcte.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int hores;
            int minuts;
            int segons;
            string resultatComprovacio;

            //inicialitzacio
            Console.WriteLine("introdueix aqui l'hora");
            hores = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("introdueix aqui els minuts");
            minuts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introdueix aqui els segons");
            segons = Convert.ToInt32(Console.ReadLine());

            //calcul funcio
            resultatComprovacio = ComprovadorHora(hores, minuts, segons);

            //output
            Console.WriteLine(resultatComprovacio);
        }

        static string ComprovadorHora(int hores, int minuts, int segons)
        {
            string resultat;

            //condicional
            if (hores >= 0 && hores <= 23 && minuts >= 0 && minuts <= 59 && segons >= 0 && segons <= 59)
            {
                return resultat = ($"l'hora actual es {hores}:{minuts:00}:{segons:00}");
            }
            else
            {
                return resultat = ("proporciona una hora correcte");
            }
        }
    }
}