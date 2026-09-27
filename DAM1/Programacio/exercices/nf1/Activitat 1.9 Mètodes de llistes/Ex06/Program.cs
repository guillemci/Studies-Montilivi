namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// Exercici 06
        /// Retorna el valor més gran de la llista.
        /// </summary>
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 6, 7, 9 };
            Console.WriteLine(MaximLlista(numeros));
        }

        public static int MaximLlista(List<int> llista)
        {
            int numero = llista[0];

            for (int i = 0; i < llista.Count; i++)
            {
                if (numero < llista[i])
                {
                    numero = llista[i];
                }
            }
            return numero;
        }
    }
}
