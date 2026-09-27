namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 10
        /// Retorna 'true' si 'valor' apareix dins la taula 't', cridant a 'PosicioDe'.
        /// </summary>
        static void Main(string[] args)
        {
            int[] array = { 1, 20, 10, 5 };
            int valor = 20;
            Console.WriteLine($"a retornat: {Conte(array, valor)}");
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

        public static bool Conte(int[] t, int valor)
        {
            return PosicioDe(t, valor) != -1;
        }
    }
}
