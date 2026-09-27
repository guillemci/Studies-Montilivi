namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 03
        /// Retorna la suma de tots els elements de la 'taula'.
        /// </summary>
        static void Main(string[] args)
        {
            int[] newArray = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine($"la suma de tots els elements es: {(SumaTaula(newArray))}");
        }

        public static int SumaTaula(int[] taula)
        {
            int suma = 0;

            for (int i = 0; i < taula.Length; i++)
                suma += taula[i];

            return suma;
        }
    }
}
