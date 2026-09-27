namespace Ex12
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 12
        /// Retorna un string amb el contingut de la taula, formatat.
        /// Exemple: per a [10, 20] ha de retornar "Index 0: 10\nIndex 1: 20"
        /// </summary>
        static void Main(string[] args)
        {
            int[] taula = { 10, 20 };
            Console.WriteLine(TaulaAString(taula));
        }

        public static string TaulaAString(int[] taula)
        {
            string valors = "";

            for (int i = 0; i < taula.Length; i++)
            {
                valors += ($"Index {i}: {taula[i]}");
                if (i < taula.Length - 1) valors += "\n";
            }

            return valors;
        }
    }
}
