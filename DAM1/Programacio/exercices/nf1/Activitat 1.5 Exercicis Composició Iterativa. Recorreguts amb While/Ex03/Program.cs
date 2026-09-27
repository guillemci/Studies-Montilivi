namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa per a saber quants valors positius i negatius hem introduït per teclat.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int contPositius = 0, contNegatius = 0;
            Console.WriteLine("introdueix aqui els valors que vulguis clasificar entre positiu i negatiu, per finalitzar el programa introdueix un 0");
            int numero;
               
            //inicialitzacio
            numero = Convert.ToInt32(Console.ReadLine());

            //bucle
            while (numero != 0)
            {
                //element principal del bucle (numero)

                if (numero > 0)
                {
                    contPositius++;
                }

                if (numero < 0)
                {
                    contNegatius++;
                }
                //element condicional del bucle
                numero = Convert.ToInt32(Console.ReadLine());
            }

            //output
            Console.WriteLine($"el total de numeros positius contats a sigut de {contPositius}");
            Console.WriteLine($"el total de numeros negatius contats a sigut de {contNegatius}");
        }
    }
}