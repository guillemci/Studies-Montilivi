namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// Exercici 16
        /// Retorna una matriu NxM plena per files.
        /// Exemple (n=3, m=2):
        /// 1 1
        /// 2 2
        /// 3 3
        /// </summary>
        static void Main(string[] args)
        {
            int n = 3;
            int m = 2;

            int[][] matriuRetornat = OmplirMatriuPerFiles(n, m);

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

        public static int[][] OmplirMatriuPerFiles(int n, int m)
        {
            int[][] matriu = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matriu[i] = new int[m];

                for (int j = 0; j < m; j++)
                {
                    matriu[i][j] = i + 1;
                }
            }
            return matriu;
        }
    }
}
