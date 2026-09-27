namespace Ex01
{
    internal class Program
    {
        /// <summary>
        /// Exercici 01
        /// Retorna una llista amb els n primers números naturals.
        /// Exemple: n=3 -> [1, 2, 3]
        /// </summary>
        static void Main(string[] args)
        {
            int n = 8;
            var naturals = new List<int>(OmpleNaturals(n));
            for (int i = 0; i < naturals.Count; i++)
                Console.WriteLine(naturals[i]);
        }

        public static List<int> OmpleNaturals(int n)
        {
            int cont = 1;

            var naturals = new List<int>();

            while (cont <= n)
            {
                naturals.Add(cont);
                cont++;
            }

            return naturals;
        }
    }
}
