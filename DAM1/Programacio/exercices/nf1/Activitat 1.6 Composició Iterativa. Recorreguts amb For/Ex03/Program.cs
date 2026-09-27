namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani dos números i mostri per pantalla tots els valors compresos entre
        ///aquests dos números.
        ///ENTRA n1: 5
        ///ENTRA n2: 900
        ///5, 6, ………., 900
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Aquest programa et mostrara tots els numeros dints un rang");
            Console.WriteLine("entra el primer numero");

            //variables
            int v1 = Convert.ToInt32(Console.ReadLine());
            int v2 = Convert.ToInt32(Console.ReadLine());
            int v1cache = v1;

            Console.WriteLine("entra el segon numero");

            //variable i bucle
            for (int i = v1; i <= v2; i++)
            {
                //comprovador primer recoregut
                if (v1 == v1cache)
                {
                    Console.WriteLine("en aquest rang de numeros introduits hi han els seguents numeros:");
                }

                //output
                Console.WriteLine(v1);
            }
        }
    }
}