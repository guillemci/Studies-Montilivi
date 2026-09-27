namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// Exercici 10
        /// Retorna 'true' si 'valor' apareix dins la llista, cridant a 'PosicioDe'.
        /// </summary>
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 6, 4, 5 };
            int valor = 5;
            Console.WriteLine(Conte(list,valor));
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

        public static bool Conte(List<int> llista, int valor)
        {
            bool conte = false;
            return conte = PosicioDe(llista, valor) != -1;
        }
    }
}
