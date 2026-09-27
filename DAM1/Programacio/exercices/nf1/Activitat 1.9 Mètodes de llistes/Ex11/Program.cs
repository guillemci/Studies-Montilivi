namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// Exercici 11
        /// Retorna 'true' si 'valor' apareix a la llista dins l'interval
        /// d'índexs [indexDesDe, indexFinsA] (ambdós inclosos).
        /// </summary>
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 5, 6, 8, 10 };
            int indexDesDe = 2;
            int indexFinsA = 4;
            int valor = 10;
            Console.WriteLine(ConteEnRang(list, valor, indexDesDe, indexFinsA));
        }

        public static bool ConteEnRang(List<int> llista, int valor, int indexDesDe, int indexFinsA)
        {
            bool trovat = false;
            while (indexDesDe <= indexFinsA && !trovat)
            {
                if (valor == llista[indexDesDe]) trovat = true;
                else indexDesDe++;
            }

            return trovat;
        }
    }
}
