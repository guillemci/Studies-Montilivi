namespace Ex17
{
    internal class Program
    {
        /// <summary>
        /// Exercici 17
        /// Retorna una matriu NxM plena per columnes.
        /// Exemple (n=3, m=2):
        /// 1 2
        /// 1 2
        /// 1 2
        /// </summary>
        static void Main(string[] args)
        {
            int n = 3;
            int m = 2;

            int[][] matriuRetornat = OmplirMatriuPerColumnes(n, m);

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

        public static int[][] OmplirMatriuPerColumnes(int n, int m)
        {
            int[][] matriu = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matriu[i] = new int[m];
            }

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    matriu[i][j] = j + 1;
                }
            }
            return matriu;
        }
    }
}
