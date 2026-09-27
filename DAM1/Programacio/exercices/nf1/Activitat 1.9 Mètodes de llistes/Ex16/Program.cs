namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// Exercici 16
        /// Retorna una matriu NxM plena per files.
        /// Exemple (nFiles=3, nColumnes=2):
        /// {{1, 1}
        /// {2, 2}
        /// {3, 3}}
        static void Main(string[] args)
        {
            int n = 3;
            int m = 2;

            List<List<int>> llistaDeLlistaRetornada = OmpleMatriuPerFiles(n, m);

            Console.WriteLine("matriu retornada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{llistaDeLlistaRetornada[i][j]} ");
                }
                Console.WriteLine();
            }

        }

        public static List<List<int>> OmpleMatriuPerFiles(int nFiles, int nColumnes)
        {
            List<List<int>> llistaLlista = new List<List<int>>();

            for (int i = 0; i < nFiles; i++) 
            {
                List<int> fila = new List<int>();
                for (int j = 0; j < nColumnes; j++)
                {
                    fila.Add(i + 1);
                }
                llistaLlista.Add(fila);
            }
            return llistaLlista;
        }
    }
}
