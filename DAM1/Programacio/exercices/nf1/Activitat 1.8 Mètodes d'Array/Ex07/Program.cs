namespace Ex07
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 07
        /// Retorna el promig de tots els elements de la 'taula'.
        /// </summary>
        static void Main(string[] args)
        {
            int[] taula = { 1, 2, 4, 9, 12 };

            Console.WriteLine($"la mitjana dels valors de la taula es de: {MitjanaTaula(taula)}");
        }

        public static double MitjanaTaula(int[] taula)
        {
            int suma = 0;
            int mitjana;

            for (int i = 0; i < taula.Length; i++)
                suma += taula[i];

            mitjana = suma / taula.Length;

            return suma;
        }
    }
}
