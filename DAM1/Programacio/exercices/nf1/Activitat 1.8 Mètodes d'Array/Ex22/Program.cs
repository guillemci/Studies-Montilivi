namespace Ex22
{
    internal class Program
    {
        /// <summary>
        /// Exercici 22
        /// Retorna un array de 2 enters [fila, columna] amb la posició
        /// del valor més petit de la 'matriu'.
        /// </summary>
        static void Main(string[] args)
        {
            int[][] matriu = new int[][]
            {
                new int[] { 3, 9, 1 },
                new int[] { 8, 4 },
                new int[] { 7, 2, 6, 0 }
            };

            int[] Posiciominim = PosicioMinimMatriu(matriu);

            Console.WriteLine($"la fila on es trova l'element mes petit es la {Posiciominim[0]}");
            Console.WriteLine($"la columna on es trova l'element mes petit es la {Posiciominim[1]}");
            Console.WriteLine($"Aquest es el numero {matriu[Posiciominim[0]][Posiciominim[1]]}");
        }

        public static int[] PosicioMinimMatriu(int[][] matriu)
        {
            int fila = 0;
            int columna = 0;
            int min = matriu[0][0];

            for (int i = 0; i < matriu.Length; i++)
            {
                for (int j = 0; j < matriu[i].Length; j++)
                {
                    if (matriu[i][j] < min)
                    {
                        min = matriu[i][j];
                        fila = i;
                        columna = j;
                    }
                }
            }

            int[] arrayposicio = { fila, columna};

            return arrayposicio;
        }
    }
}
