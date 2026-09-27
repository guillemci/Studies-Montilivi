namespace Ex07
{
    internal class Program
    {
        /// <summary>
        /// Exercici 07
        /// Retorna el promig de tots els elements de la llista.
        /// </summary>
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 6, 7, 9 };
            Console.WriteLine(MitjanaLlista(numeros));
        }

        public static double MitjanaLlista(List<int> llista)
        {
            int numero = 0;
            int cont = 0;

            for (int i = 0; i < llista.Count; i++)
            {
                numero += llista[i];
                cont++;
            }

            numero = numero / cont;

            return numero;
        }
    }
}
