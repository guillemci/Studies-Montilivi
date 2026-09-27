namespace Ex18
{
    internal class Program
    {
        /// <summary>
        /// Exercici 18
        /// Retorna una matriu NxM plena amb números naturals consecutius (començant per 1).
        /// Exemple (nFiles=2, nColumnes=3):
        /// {{1, 2, 3}
        /// {4, 5, 6}}
        /// </summary>
        static void Main(string[] args)
        {
            int n = 2;
            int m = 3;

            List<List<int>> matriuRetornat = OmpleMatriuConsecutius(n, m);

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

        public static List<List<int>> OmpleMatriuConsecutius(int nFiles, int nColumnes)
        {
            int valor = 1;
            
            List<List<int>> matriu = new List<List<int>>();

            for (int i = 0; i < nFiles; i++)
            {
                List<int> fila = new List<int>();
                for (int j = 0; j < nColumnes; j++)
                {
                    fila.Add(valor);
                    valor++;
                }
                matriu.Add(fila);
            }

            return matriu;
        }
    }
}
