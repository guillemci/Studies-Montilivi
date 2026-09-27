namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 11
        /// Retorna 'true' si 'valor' apareix a la taula 't' dins l'interval
        /// d'índexs [indexDesDe, indexFinsA] (ambdós inclosos).
        /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 30, 10, 20, -15, 100, 0, -18 };
            int valorinici = 0;
            int valorfianl = 3;
            int valor = -18;

            Console.WriteLine($"a retornat: {ConteEnRang(array, valor, valorinici, valorfianl)}");
        }

        public static bool ConteEnRang(int[] t, int valor, int indexDesDe, int indexFinsA)
        {
            int valorComparar;
            bool final = false;
            while (indexDesDe <= indexFinsA && !final)
            {
                valorComparar = t[indexDesDe];
                if (valorComparar == valor)
                {
                    final = true;
                }
                else
                {
                    indexDesDe++;
                }
            }
            return final;
        }
    }
}
