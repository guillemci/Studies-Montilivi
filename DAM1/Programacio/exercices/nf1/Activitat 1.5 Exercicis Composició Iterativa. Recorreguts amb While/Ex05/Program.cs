namespace Ex05
{
    internal class Program
    {
        /// <summary>
        /// Fer un programa que vagi demanant per teclat números fins trobar el zero i calculi la mitjana
        /// dels valors introduïts.
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            double resultat;
            int i = 0;
            double numerosAcomulats = 0;
            int numeroIntroduit;

            //inicialitzacio
            Console.WriteLine("introdueix els numeros dels cuals en vulguis fer una mitja");
            numeroIntroduit = Convert.ToInt32(Console.ReadLine());

            //bucle
            while (numeroIntroduit != 0)
            {
                numerosAcomulats += numeroIntroduit;
                i++;
                numeroIntroduit = Convert.ToInt32(Console.ReadLine());
            }

            //calcul
            if (numerosAcomulats != 0)
            {
                resultat = numerosAcomulats / i;
                Console.WriteLine($"la mitja final d'aquests numeros introduits a estat de {resultat}");
            }
            else
            {
                Console.WriteLine("introdueix un numero que no sigui 0 per calcular la mitjana");
            }
        }
    }
}
