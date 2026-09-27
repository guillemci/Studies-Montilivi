namespace Ex01
{
    internal class Program
    {
        /// <summary>
        /// Exercici 01
        /// Retorna un array de longitud 'n' amb els N primers números naturals.
        /// Exemple: n=3 -> [1, 2, 3]
        /// </summary>
        static void Main(string[] args)
        {
            int n = 3;

            int[] hola = OmpleNaturals(n);

            for (int i = 0; i < hola.Length; i++)
                Console.WriteLine(hola[i]);
        }

        public static int[] OmpleNaturals(int n)
        {
            int[] hola = new int[n];

            for (int i = 0; i < n; i++)
                hola[i] = i + 1;

            return hola;
        }
    }
}
