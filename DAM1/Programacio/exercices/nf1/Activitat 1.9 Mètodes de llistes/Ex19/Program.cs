namespace Ex19
{
    internal class Program
    {
        /// <summary>
        /// Exercici 19
        /// Retorna una matriu NxM plena amb números naturals consecutius en ordre invers.
        /// Exemple (nFiles=2, nColumnes=3) -> Total 6 elements:
        /// {{6, 5, 4}
        /// {3, 2, 1}}
        /// </summary>
        static void Main(string[] args)
        {
            int n = 2;
            int m = 3;

            List<List<int>> matriuRetornat = OmpleMatriuConsecutiusInvers(n, m);

            Console.WriteLine("matriu retornada:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriuRetornat[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        public static List<List<int>> OmpleMatriuConsecutiusInvers(int nFiles, int nColumnes)
        {
            int valor = nColumnes * nFiles;

            List<List<int>> matriu = new List<List<int>>();

            for (int i = 0; i < nFiles; i++)
            {
                List<int> fila = new List<int>();
                for (int j = 0; j < nColumnes; j++)
                {
                    fila.Add(valor);
                    valor--;
                }
                matriu.Add(fila);
            }

            return matriu;
        }
    }
}
