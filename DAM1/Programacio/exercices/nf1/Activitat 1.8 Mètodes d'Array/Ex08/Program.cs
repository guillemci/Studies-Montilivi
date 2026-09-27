namespace Ex08
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 08
        /// MODIFICA la 'taula' original, invertint l'ordre dels seus elements.
        /// (El primer element passa a ser l'últim, el segon el penúltim, etc.)
        /// </summary>
        static void Main(string[] args)
        {
            int[] taula = { 7, 9, 10, 11, 17, 12, 13 };
            CapgirarTaula(taula);
        }

        public static void CapgirarTaula(int[] taula)
        {
            int valorAuxinici;
            int valorAuxfinal;
            for (int i = 0; i < taula.Length / 2; i++)
            {
                valorAuxfinal = taula[(taula.Length -1) -i];
                valorAuxinici = taula[i];
                taula[i] = valorAuxfinal;
                taula[(taula.Length - 1) - i] = valorAuxinici;
                
            }

            Console.Write("la taula capgirada es: ");
            for (int i = 0; i < taula.Length; i++)
            {
                Console.Write($"{taula[i]} ");
            }
        }
    }
}
 