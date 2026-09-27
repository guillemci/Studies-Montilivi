namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// Exercici 09
        /// Retorna la primera posició (índex) on apareix 'valor' a la llista.
        /// Si 'valor' no apareix, retorna -1.
        /// </summary>
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 6, 4, 5 };
            int valor = 5;
            Console.WriteLine(PosicioDe(list, valor));
        }

        public static int PosicioDe(List<int> llista, int valor)
        {
            int cont = 0;
            bool trovat = false;
            while (cont < llista.Count && !trovat)
            {
                if (valor == llista[cont]) trovat = true;
                else cont++;
            }
            if (trovat) return cont;
            else return -1;
        }
    }
}
