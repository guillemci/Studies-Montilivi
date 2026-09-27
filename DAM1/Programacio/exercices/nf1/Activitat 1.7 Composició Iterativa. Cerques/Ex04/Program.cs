using System.Runtime.ConstrainedExecution;

namespace Ex04
{
    internal class Program
    {

        /// <summary>
        /// es un programa que demana un número per teclat i mostra la primera posició a on es troba
        ///aquest número en el fitxer NUMEROS.TXT.
        ///● Per exemple, si l’usuari entra el número “1” llavors els programa ha de mostrar per pantalla
        ///un “4”. La “LINIA 4” és la primera posició de fitxer a on apareix el número “1”.
        ///● Si el número no es troba a dins del fitxer, el programa ha de mostrar per pantalla un “-1”.
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("NUMEROS.txt");
            int numeroUsuari = Convert.ToInt32(Console.ReadLine());
            int lineanum;
            int cont = 0;
            string linea;
            bool trovat = false;

            while ((linea = trova.ReadLine()) != null && !trovat)
            {
                lineanum = Convert.ToInt32(linea);
                trovat = lineanum == numeroUsuari;
                cont++;
            }

            if (trovat)
                Console.WriteLine($"la primera posicio del nuemero demanat: {numeroUsuari} es la linea {cont}");
            else
                Console.WriteLine("el numero no s'ha trovat '-1'");
        }
    }
}
