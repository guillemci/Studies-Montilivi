namespace Ex08B
{
    internal class Program
    {
        //altre logica que vaig fer abans, cambiada per una mes simple
        static void Main(string[] args)
        {
            int resultat = 0;
            int i = 0;

            Console.WriteLine("");
            for (int numeroDemanant = Convert.ToInt32(Console.ReadLine()); i < numeroDemanant; i++)
            {
                int calcul = numeroDemanant - i;
                Console.WriteLine(calcul);

                if (i == 0) resultat += calcul;
                else resultat *= calcul;

                Console.WriteLine(resultat);
            }
        }
    }
}
