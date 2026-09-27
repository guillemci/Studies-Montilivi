namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS2.TXT.
        /// </summary>
        static void Main(string[] args)
        {
            //variable
            StreamReader trova = new StreamReader("NUMEROS2.txt");
            string linea;
            double resultat;
            int numerosIntroduits = 0;
            double numerosAcomulats = 0;

            //inicialitzacio
            linea = trova.ReadLine();

            //bucle
            while (linea != null) //condicio de final
            {
                int numerollegit = Convert.ToInt32(linea);
                numerosAcomulats += numerollegit;
                numerosIntroduits++;
                linea = trova.ReadLine();
            }
            trova.Close();

            //calcul
            resultat = numerosAcomulats / (double)numerosIntroduits;

            //output
            Console.WriteLine($"la mitja total de tots els numeros del fitxer NUMEROS2 ES DE {resultat}");
        }
    }
}