namespace Ex07B
{
    internal class Program 
    {
        //altre logica que vaig fer abans, cambiada per una mes simple
        static void Main(string[] args)
        {
            int resultat = 0;
            int i = 0;

            Console.WriteLine("introdueix el numero del qual en vulguis saber els seus anteriors i sumar-los");
            for (int numeroDemanant = Convert.ToInt32(Console.ReadLine()); i < numeroDemanant; i++)
            {
                int calcul = numeroDemanant - i;
                resultat += calcul;
            }
            Console.WriteLine($"el resultat es: {resultat}");
        }
    }
}
