namespace Ex05
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 05
        /// Retorna l'índex (posició) del valor més petit de la 'taula'.
        /// Si hi ha empats, retorna la primera posició.
        /// </summary>
        static void Main(string[] args)
        {
            int[] taula = { 30, 30, 30 };
            Console.WriteLine($"el valor mes petit esta a la posicio {PosicioMinimTaula(taula)}");
        }

        public static int PosicioMinimTaula(int[] taula)
        {
            int numeroMesPetit = taula[0];
            int indexmespetit = 0;

            for (int i = 0; i < taula.Length; i++)
            {
                if (numeroMesPetit > taula[i])
                {
                    numeroMesPetit = taula[i];
                    indexmespetit = i;
                }
            }
            return indexmespetit;
        }
    }
}
