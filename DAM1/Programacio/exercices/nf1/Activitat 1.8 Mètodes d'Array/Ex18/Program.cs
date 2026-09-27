namespace Ex18
{
    internal class Program
    {
        /// <summary>
        /// Exercici 18
        /// Retorna una matriu NxM plena amb números naturals consecutius (començant per 1).
        /// Exemple (n=2, m=3):
        /// 1 2 3
        /// 4 5 6
        /// </summary>
        static void Main(string[] args)
        {
            int n = 2;
            int m = 3;

            int[][] matriuRetornat = OmplirMatriuPerFiles(n, m);

            Console.WriteLine("numeros naturals consecutius");
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

            int valor = 0;

            for (int i = 0; i < n; i++)
            {
                matriu[i] = new int[m];

                for (int j = 0; j < m; j++)
                {
                    matriu[i][j] = valor + 1;
                    valor++;
                }
            }
            return matriu;
        }
    }
}
