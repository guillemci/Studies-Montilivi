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
            List<List<int>> matriu = new List<List<int>>();
            {
                matriu.Add(new List<int> { 7, 2, 6, 2 });
                matriu.Add(new List<int> { 8, 4, 20, 14 });
                matriu.Add(new List<int> { 7, 2, 6, 1 });
            };

            int minim = MinimMatriu(matriu);
            Console.WriteLine($"el valor mes petit que apareix a la taula es: {minim}");
        }

        public static int MinimMatriu(List<List<int>> matriu)
        {
            int min = matriu[0][0];

            for (int i = 0; i < matriu.Count; i++)
            {

                for (int j = 0; j < matriu[i].Count; j++)
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
