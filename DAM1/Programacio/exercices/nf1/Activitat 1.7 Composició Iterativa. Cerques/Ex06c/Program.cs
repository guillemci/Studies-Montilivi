using System.Runtime.ConstrainedExecution;

namespace Ex06c
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència de valors procedents d’un fitxer, informar per a cada valor, si és
        /// primer o no(CERCA O RECORREGUT?) Usar el fitxer ALGUNSPRIMERS.TXT
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader trovar = new StreamReader("ALGUNSPRIMERS.txt");
            string linea;
            int cont = 0;
            int i = 2;
            int numeroLinea;

            while ((linea = trovar.ReadLine()) != null)
            {
                numeroLinea = Convert.ToInt32(linea);
                while (i != numeroLinea / 2 && cont != 1)
                {
                    if (numeroLinea % i == 0) cont++;
                    i++;
                }

                if (cont == 0) Console.WriteLine($"{numeroLinea} es un numero primari");
                else Console.WriteLine($"{numeroLinea} no es un numero primari");
                cont = 0;
                i = 2;
            }
            trovar.Close();
        }
    }
}
