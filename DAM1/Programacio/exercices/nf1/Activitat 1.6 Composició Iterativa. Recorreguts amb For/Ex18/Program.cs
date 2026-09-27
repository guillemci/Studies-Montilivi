namespace Ex18
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que mostre una piràmide de números com la següent
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            int valor = 5;

            //bucle
            for (int i = 0; i < valor; i++)
            {
                //bucle niat AKA doble bucle
                for (int k = valor; i < k; k--)
                {
                    Console.Write(" ");
                }

                //bucle niat AKA doble bucle
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{1 + j} ");
                }

                Console.WriteLine();
            }
        }
    }
}