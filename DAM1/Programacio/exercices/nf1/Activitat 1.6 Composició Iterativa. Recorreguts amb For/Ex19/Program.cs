namespace Ex19
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani un número enter positiu n i mostri el següent ( exemple per n=4)
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            int valor = 0;
            Console.WriteLine("introdueix el numero del qual en vulguis fer la suma dels seus anteriors");
            int valorusuari = Convert.ToInt32(Console.ReadLine());

            //bucle
            for (int i = 1; i <= valorusuari; i++)
            {
                //bucle
                valor += i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                    if (j < i) Console.Write("+ ");
                    if (j == valorusuari) Console.WriteLine($"= {valor}");
                }
                Console.WriteLine();
            }
        }
    }
}