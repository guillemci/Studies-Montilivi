namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// Fer un programa que donat un número enter positiu et digui quantes xifres té.
        /// Quina és la condició de final en aquest cas?
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int numero;
            int xifres = 0;

            //inicialitzacio variables
            Console.WriteLine("introdueix aqui un numero per saber el numero de xifres que te");
            numero = Convert.ToInt32(Console.ReadLine());


            //bucle
            while (numero != 0) //condicio de final (es a dir la condicio de final sera que el numero sigui equivalent a 0)
            {
                numero = numero / 10; //element principal
                xifres++;
            }

            //output
            Console.WriteLine($"el numero de xifres del valor proporcionat es de {xifres}");
        }
    }
}