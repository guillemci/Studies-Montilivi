namespace Ex17
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que mostri per pantalla totes les taules de multiplicar del 0 al 5.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int taulesAImprimir = 5;
            int numeroDintsTaula = 10;

            Console.WriteLine("aquest programa escriura totes les taules de multiplicar del 0 al 5");

            //bucle niat AKA bucle doble
            for (int i = 0; i <= taulesAImprimir; i++)
            {
                for (int j = 0; j <= numeroDintsTaula; j++)
                {
                    if (j == 0)
                    {
                        //output
                        Console.WriteLine($"la taula de multiplicar del {i} es:");
                    }

                    Console.WriteLine(i * j);
                }
            }
        }
    }
}
