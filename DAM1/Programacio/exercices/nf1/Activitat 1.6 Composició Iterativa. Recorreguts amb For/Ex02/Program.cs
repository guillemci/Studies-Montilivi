namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// Escriure els 20 primers números parells.
        /// 2, 4, 6,......... 40
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            int comptador = 1;

            //bucle
            for (int i = 1; comptador <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    //output1
                    Console.WriteLine($"el numero {i} es parell");
                    comptador++;
                }
                else
                {
                    //output1
                    Console.WriteLine($"el numero {i} es imparell");
                }
            }
        }
    }
}
