namespace Ex19
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 2;
            int m = 3;

            int[][] matriuRetornat = OmplirMatriuPerFiles(n, m);

            Console.WriteLine("numeros naturals consecutius inversos:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matriuRetornat[i][j]} ");
                }
                Console.WriteLine();
            }

        }

        public static int[][] OmplirMatriuPerFiles(int n, int m)
        {
            int[][] matriu = new int[n][];

            int valor = n * m;

            for (int i = 0; i < n; i++)
            {
                matriu[i] = new int[m];

                for (int j = 0; j < m; j++)
                {
                    matriu[i][j] = valor--;
                }
            }
            return matriu;
        }
    }
}
