namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// 10. Fes un programa que mostri tots els números múltiples de 4 entre el 0 i el 300.
        /// ● Després de mostrar 20 números, el programa ha de pausar-se fins que que l’usuari premi
        /// una tecla.
        /// ● Utilitza la instrucció Console.ReadKey() per esperar que l’usuari entri una tecla
        /// </summary>
        static void Main(string[] args)
        {
            //bucle
            for (int i = 0; i <= 300; i++)
            {
                //elements treballats i outputs
                if (i % 4 == 0) Console.WriteLine($"{i} es un multiple de 4");
                else Console.WriteLine($"{i} no es un multiple de 4");
                if (i == 20)
                {
                    Console.WriteLine("prem una tecla per continuar");
                    Console.ReadLine();
                }
            }
        }
    }
}
