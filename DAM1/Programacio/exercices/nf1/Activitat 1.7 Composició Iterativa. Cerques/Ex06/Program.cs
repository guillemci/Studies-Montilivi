namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// Donat un valor enter positiu introduït pel teclat, indicar si és primer o no.
        /// </summary>
        static void Main(string[] args)
        {
            int cont = 0;
            int contadorEscalador = 2;

            Console.WriteLine("introdueix un valor per saber si es primari");
            int numeroTeclat = Convert.ToInt32(Console.ReadLine());


            while (contadorEscalador != numeroTeclat / 2 && cont != 1)
            {
                if (numeroTeclat % contadorEscalador == 0) cont++;
                contadorEscalador++;
            }

            if (cont == 0) Console.WriteLine($"{numeroTeclat} es un numero primari");
            else Console.WriteLine($"{numeroTeclat} no es un numero primari");
        }
    }
}
