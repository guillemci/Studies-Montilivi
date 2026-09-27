namespace Ex12
{
    internal class Program
    {
        /// Exercici 12
        /// Retorna un string amb el contingut de la llista, formatat.
        /// Exemple: per a {10, 20} ha de retornar "Index 0: 10\nIndex 1: 20"
        /// </summary>
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 5, 6, 8, 10 };

            Console.WriteLine(LlistaAString(list));
        }

        public static string LlistaAString(List<int> llista)
        {
            string StringDeLlista = "";
            for (int i = 0; i < llista.Count; i++)
            {
                StringDeLlista += ($"Index {i}: {llista[i]}");
                if (i != llista.Count - 1) StringDeLlista += "\n";
            }
            return StringDeLlista;
        }
    }
}
