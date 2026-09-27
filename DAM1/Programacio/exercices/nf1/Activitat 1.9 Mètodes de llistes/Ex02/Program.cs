namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// Exercici 02
        /// Retorna una llista amb n números enters aleatoris entre -100 i 100.
        /// </summary>
        static void Main(string[] args)
        {
            int n = 8;
            List<int> naturals = new List<int>(OmpleNaturals(n));
            for (int i = 0; i < naturals.Count; i++)
                Console.WriteLine(naturals[i]);
        }

        public static List<int> OmpleNaturals(int n)
        {
            Random r = new Random();
            int cont = 1;

            var naturals = new List<int>();

            while (cont <= n)
            {
                naturals.Add(r.Next(-100,101));
                cont++;
            }

            return naturals;
        }
    }
}
