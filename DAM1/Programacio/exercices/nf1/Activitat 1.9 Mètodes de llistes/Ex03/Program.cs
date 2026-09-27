namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// Exercici 03
        /// Retorna la suma de tots els elements de la llista.
        /// </summary>
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 6, 7, 9 };
            Console.WriteLine(SumaLlista(numeros));
        }

        public static int SumaLlista(List<int> llista)
        {
            int numero = 0;

            for (int i = 0; i < llista.Count; i++)
            {
                numero += llista[i];
            }
            return numero;
        }
    }
}
