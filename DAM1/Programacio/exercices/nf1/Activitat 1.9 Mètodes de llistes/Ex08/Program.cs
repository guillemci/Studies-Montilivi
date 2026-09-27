namespace Ex08
{
    internal class Program
    {
        /// <summary>
        /// Exercici 08
        /// MODIFICA la llista original, invertint l'ordre dels seus elements.
        /// (El primer element passa a ser l'últim, el segon el penúltim, etc.)
        /// </summary>
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 6, 4, 5 };
            CapgiraLlista(list);
        }

        public static void CapgiraLlista(List<int> llista)
        {
            int finalAux;
            int iniciAux;

            for (int i = 0; i < llista.Count / 2; i++)
            {
                iniciAux = llista[i];
                finalAux = llista[llista.Count - 1 - i];
                llista[i] = finalAux;
                llista[llista.Count - 1 - i] = iniciAux;
            }

            for (int i = 0; i < llista.Count; i++)
            {
                Console.WriteLine(llista[i]);
            }
        }
    }
}
