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

            List<List<int>> matriuRetornat = OmpleMatriuIdentitat(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriuRetornat[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        public static List<List<int>> OmpleMatriuIdentitat(int nFiles)
        {
            List<List<int>> matriu = new List<List<int>>();

            for (int i =0; i < nFiles; i++)
            {
                List<int> fila = new List<int>();
                for (int j = 0; j < nFiles; j++)
                    fila.Add(0);

                matriu.Add(fila);
            }
            for (int i = 0; i < nFiles;i++)
            {
                matriu[i][i] = 1;
            }

            return matriu;
        }
    }
}
