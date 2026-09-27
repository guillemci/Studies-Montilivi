namespace Ex06e
{
    internal class Program
    {
        /// <summary>
        /// e. Escriu un programa que demani un valor n per teclat, i mostri per pantalla els n primers
        /// nombres primers.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("introdueix aquest numeros per obtenir x cantitat de numeros primaris");
            int numerosATrovar = Convert.ToInt32(Console.ReadLine());
            int trovats = 0;
            int cont = 0;
            int nombreIncremental = 0;

            while (trovats != numerosATrovar)
            {

                for (int contadorEscala = 1; contadorEscala <= nombreIncremental; contadorEscala++)
                {
                    if (nombreIncremental % contadorEscala == 0)
                        cont++;
                }

                if (cont == 2)
                {
                    trovats++;
                    Console.WriteLine($"{nombreIncremental} es un numero primari");
                }
                else
                    Console.WriteLine($"{nombreIncremental} no es un numero primari");

                nombreIncremental++;
                cont = 0;
            }
        }
    }
}
