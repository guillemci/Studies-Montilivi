namespace Ex20
{
    internal class Program
    {
        /// <summary>
        /// Exercici 20
        /// Retorna una matriu quadrada NxN que és la matriu identitat.
        /// (1 a la diagonal, 0 a la resta).
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("especifica la longitud de la matriu");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] matriuRetornat = OmplirMatriuPerFiles(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriuRetornat[i][j]} ");
                }
                Console.WriteLine();
            }

        }

        public static int[][] OmplirMatriuPerFiles(int n)
        {
            int[][] matriu = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matriu[i] = new int[n];
                matriu[i][i] = 1;
            }
            return matriu;

        }
    }
}
