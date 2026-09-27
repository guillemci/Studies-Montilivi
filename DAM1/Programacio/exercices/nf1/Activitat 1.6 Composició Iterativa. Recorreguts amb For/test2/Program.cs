namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int k = 5; i < k; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{1 + j} ");
                }

                Console.WriteLine();
            }
        }
    }
}
