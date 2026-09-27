namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 06
        /// Retorna el valor més gran de la 'taula'.
        /// </summary>
        static void Main(string[] args)
        {
            int[] taula = { 30, 30, 90 };

            Console.WriteLine($"el valor mes gran es el {MaximTaula(taula)}");
        }

        public static int MaximTaula(int[] taula)
        {
            int numeroMesGran = taula[0];

            for (int i = 0; i < taula.Length; i++)
            {
                if (numeroMesGran < taula[i])
                    numeroMesGran = taula[i];
            }
            return numeroMesGran;
        }
    }
}
