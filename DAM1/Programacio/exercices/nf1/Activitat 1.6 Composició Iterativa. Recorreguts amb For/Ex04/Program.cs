namespace Ex04
{
    internal class Program
    {
        /// <summary>
        /// Modifica l’anterior programa fent que no es mostrin els números que siguin múltiples de 7
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Aquest programa et mostrara tots els numeros dints un rang i nomes el multiples de 7");
            Console.WriteLine("entra el primer numero");

            //variables
            int v1 = Convert.ToInt32(Console.ReadLine());
            int v2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("entra el segon numero");

            Console.WriteLine("en aquest rang de numeros introduits hi han els seguents numeros:");
            //variable i bucle
            for (int i = v1; i <= v2; i++)
            {
                //condicionals i outputs
                if (i % 7 == 0)
                {
                    Console.WriteLine($"{i} esta en el rang i es multiple de 7");
                }
            }
        }
    }
}
