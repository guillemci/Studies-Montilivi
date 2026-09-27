namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// Fes el mateix programa però agafant les dades del fitxer NUMEROS.TXT. FI = null.
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("NUMEROS.txt");
            string linea;

            linea = trova.ReadLine();
            int i = 0;

            //bucle
            while (linea != null)
            {
                Console.WriteLine(linea); //elemenet principal + output
                i++;
                linea = trova.ReadLine();
            }
            trova.Close();

            //output 2
            Console.WriteLine($"el numero total de lineas que ha llegit i per tant numeros trovats a sigut de {i}");
        }
    }
}