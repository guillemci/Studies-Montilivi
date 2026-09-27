namespace Ex22
{
    internal class Program
    {
        /// <summary>
        /// Exercici 22
        /// Retorna una llista de 2 enters {fila, columna} amb la posició
        /// del valor més petit de la 'matriu'.
        /// </summary>
        static void Main(string[] args)
        {
            List<List<int>> matriu = new List<List<int>>();
            {
                matriu.Add(new List<int> { 7, 2, 6, 2 });
                matriu.Add(new List<int> { 8, 4, 20, 14 });
                matriu.Add(new List<int> { 7, 2, 6, 1 });
            };

            List<int> llistaReturnada = MinimMatriu(matriu);

            Console.WriteLine($"la fila on es trova l'element mes petit es la {llistaReturnada[0]}");
            Console.WriteLine($"la columna on es trova l'element mes petit es la {llistaReturnada[1]}");
            Console.WriteLine($"Aquest es el numero {matriu[llistaReturnada[0]][llistaReturnada[1]]}");
        }

        public static List<int> MinimMatriu(List<List<int>> matriu)
        {
            int fila = 0;
            int columna = 0;
            int min = matriu[0][0];

            for (int i = 0; i < matriu.Count; i++)
            {

                for (int j = 0; j < matriu[i].Count; j++)
                {
                    if (matriu[i][j] < min)
                    {
                        min = matriu[i][j];
                        fila = i;
                        columna = j;
                    }
                }
            }

            List<int> llistaRetornar = new List<int>();
            llistaRetornar.Add(fila);
            llistaRetornar.Add(columna);

            return llistaRetornar;
        }
    }
}
