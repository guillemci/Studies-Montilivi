namespace Ex04
{
    /// <summary>
    /// Exercici 04
    /// Retorna el valor més petit de la llista.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 6, 7, 9 };
            Console.WriteLine(MinimLlista(numeros));
        }

        public static int MinimLlista(List<int> llista)
        {
            int numero = llista[0];

            for (int i = 0; i < llista.Count; i++)
            {
                if (numero > llista[i])
                {
                    numero = llista[i];
                }
            }
            return numero;
        }
    }
}
