namespace Ex05
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani 10 números per teclat i que els sumi. Al final del recorregut ha de
        /// mostrar la suma de tots els números.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("aquest programa demanara 10 numeros per teclat els quals seran sumats");
            int numeroSumat = 0;
            Console.WriteLine("introdueix els numeros de els quals en vulguis fer una suma s'en demanaran 10");
            for (int i = 0; i < 10; i++)
            {
                int numero = Convert.ToInt32(Console.ReadLine());

                numeroSumat += numero;
            }

            Console.WriteLine($"el total de numeros sumats a sigut de {numeroSumat}");
        }
    }
}