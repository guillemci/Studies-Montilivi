namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani 10 números per teclat. En acabar el programa ha d’informar de quants
        /// números son positius, negatius i zeros
        /// </summary>
        static void Main(string[] args)
        {
            int numero;
            int numeroPositiu = 0;
            int numeroZero = 0;
            int numeroNegatiu = 0;

            Console.WriteLine("introdueix els numeros de els quals en vulguis saber els quals son positius" +
                "negatius i que siguin 0 s'en demanaran 10");

            //bucle
            for (int i = 0; i < 10; i++)
            {
                numero = Convert.ToInt32(Console.ReadLine());

                //condicionals
                if (numero > 0)
                    numeroPositiu++;
                else if (numero < 0)
                    numeroNegatiu++;
                else numeroZero++;
            }

            Console.WriteLine($"el total de numeros que son positius a sigut de {numeroPositiu}");
            Console.WriteLine($"el total de numeros que son negatius a sigut de {numeroNegatiu}");
            Console.WriteLine($"el total de numeros que son zero a sigut de {numeroZero}");
        }
    }
}
