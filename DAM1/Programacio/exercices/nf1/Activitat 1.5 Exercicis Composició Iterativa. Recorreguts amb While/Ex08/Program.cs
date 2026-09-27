namespace Ex08
{
    internal class Program
    {
        /// <summary>
        /// Fer un programa que vagi demanant números fins trobar el zero i ens digui el valor més gran i
        /// el valor més petit
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int numerollegit;
            int numeroMesGran;
            int numeroMesPetit;
            int cont = 0;

            //inicialitzacio;
            StreamReader trova = new StreamReader("NUMEROS2.txt");
            string linea = trova.ReadLine();
            numerollegit = Convert.ToInt32(linea);
            numeroMesGran = numerollegit;
            numeroMesPetit = numerollegit;

            //bucle
            while (numerollegit != 0) //condicio final
            {
                if (numeroMesGran < numerollegit)
                    numeroMesGran = numerollegit; //element principal

                if (numeroMesPetit > numerollegit)
                {
                    numeroMesPetit = numerollegit; //element principal
                }
                cont++;

                //condicio final actualitzacio
                linea = trova.ReadLine();
                numerollegit = Convert.ToInt32(linea);
            }
            trova.Close();

            //output
            Console.WriteLine($"el programa a acabat de llegir, el total de numeros llegits a sigut {cont}, el numero mes gran detectat a sigut {numeroMesGran} i el mes petit {numeroMesPetit}");
        }
    }
}
