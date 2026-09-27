namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introdueix aqui l'hora");
            int hores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introdueix aqui els minuts");
            int minuts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introdueix aqui els segons");
            int segons = Convert.ToInt32(Console.ReadLine());

            string resultatComprovacio = ComprovadorHora(hores, minuts, segons);

            Console.WriteLine(resultatComprovacio);
        }

        static string ComprovadorHora(int hores, int minuts, int segons)
        {
            string resultat;
            if (hores <= 24 && minuts <= 59 && segons <= 59)
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