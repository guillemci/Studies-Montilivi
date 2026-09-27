namespace Ex21
{
    /// <summary>
    /// Exercici 21
    /// Retorna el valor més petit dins de la 'matriu'.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matriu = new int[][]
            {
                new int[] { 3, 9, 1 },
                new int[] { 8, 4 },
                new int[] { 7, 2, 6, 2 }
            };

            int minim = MinimMatriu(matriu);
            Console.WriteLine($"el valor mes petit que apareix a la taula es: {minim}");
        }

        public static int MinimMatriu(int[][] matriu)
        {
            int min = matriu[0][0];

            for (int i = 0;  i < matriu.Length; i++)
            {
                for (int j = 0; j < matriu[i].Length; j++)
                {
                    if (matriu[i][j] < min)
                    {
                        min = matriu[i][j];
                    }
                }
            }
            return min;
        }
    }
}
