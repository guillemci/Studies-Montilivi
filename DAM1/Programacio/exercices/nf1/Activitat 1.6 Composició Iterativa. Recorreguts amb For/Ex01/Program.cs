namespace Ex01
{
    internal class Program
    {
        /// <summary>
        /// Escriure els 20 primers números en ordre ascendent.
        /// 1, 2, 3,........ 20
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Aquest programa mostrara els 20 primers numeros de forma ascendent");
            
            //bucle
            for(int i = 20; i > 0; i--)
            {
                //output
                Console.WriteLine(i);
            }
        }
    }
}