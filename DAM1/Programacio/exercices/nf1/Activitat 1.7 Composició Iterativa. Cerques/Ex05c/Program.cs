using System.Runtime.ConstrainedExecution;

namespace Ex05c
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència de valors procedents d’un fitxer, informar per a cada valor, si és
        /// perfecte o no(CERCA O RECORREGUT?). Usar el fitxer PERFECTES.TXT que conté el
        /// 3550336 que és perfecte i el 6 que també és perfecte.
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("PERFECTES.txt");
            int contador = 1;
            int acomulador = 0;
            int lineaNum;
            string linea;
            bool passat = false, final = false;

            while ((linea = trova.ReadLine()) != null)
            {
                lineaNum = Convert.ToInt32(linea);
                while (!passat && !final)
                {
                    if (lineaNum % contador == 0)
                        acomulador += contador;

                    passat = lineaNum <= acomulador;
                    final = contador >= lineaNum / 2;

                    contador++;
                }

                if (acomulador == lineaNum)
                    Console.WriteLine($"el numero {lineaNum} es tracta d'un numero perfecte");
                else
                    Console.WriteLine($"el numero {lineaNum} no es tracta d'un numero perfecte");

                passat = false;
                final = false;
                acomulador = 0;
                contador = 1;
            }
            trova.Close();
        }
    }
}
