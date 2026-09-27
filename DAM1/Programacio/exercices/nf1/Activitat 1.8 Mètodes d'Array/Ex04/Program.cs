namespace Ex04
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 04
        /// Retorna el valor més petit de la 'taula'.
        /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"el valor mes petit de l'array es: {PosicioMinimTaula(array)}");
        }

        public static int PosicioMinimTaula(int[] taula)
        {
            int numeroMesPetit = taula[0];

            for (int i = 0; i < taula.Length; i++)
            {
                if (numeroMesPetit > taula[i])
                    numeroMesPetit = taula[i];
            }

            return numeroMesPetit;
        }
    }
}
