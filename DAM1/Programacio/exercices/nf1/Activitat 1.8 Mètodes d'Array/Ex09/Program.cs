namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 09
        /// Retorna la primera posició (índex) on apareix 'valor' a la taula 't'.
        /// Si 'valor' no apareix, retorna -1.
        /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,5,1 };
            int valor = 1;
            Console.WriteLine($"la primera posicio on apareix valor es a: {PosicioDe(array, valor)}");
        }

        public static int PosicioDe(int[] t, int valor)
        {
            bool final = false;
            int i = 0;
            int valoractual = t[i];
            while (i < t.Length && !final)
            {
                valoractual = t[i];

                if (valoractual == valor)
                    final = true;
                else
                {
                    i++;
                }
            }

            if (final) return i;
            else return -1;
        }
    }
}
