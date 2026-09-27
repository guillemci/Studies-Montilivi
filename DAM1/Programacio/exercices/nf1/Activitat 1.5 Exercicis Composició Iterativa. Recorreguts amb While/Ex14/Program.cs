using System.Text;

namespace Ex14
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer BONUS2.TXT per al càlcul del BONUS.
        /// ● Quan apareix la paraula "BONUS", a continuació hi ha la quantitat guanyada a la
        /// següent línia.
        /// ● Si es troba "NO BONUS", no hi ha cap quantitat associada.
        /// ● Processa el fitxer per identificar les línies amb "BONUS" i extreure les quantitats de
        /// cada BONUS.
        /// ● Finalment, calcula el total dels guanys i el nombre de bitllets amb BONUS.
        /// </summary>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //variables
            StreamReader trova = new StreamReader("BONUS2.txt");
            string linea;
            int guanysTotals = 0;
            int i = 0;

            //inicialitzacio
            linea = trova.ReadLine();

            //bucle
            while (linea != null) //condicio de final
            {

                //if que mira que no sigui ni bonus ni no bonus, es a dir nomes quedaran els valors a guanyar
                
                /*if (linea != "BONUS" && linea != "NO BONUS")
                {
                    Console.WriteLine($"el bonus del ticket es de {linea}€");
                    guanysTotals += Convert.ToInt32(linea);
                }*/


                if (linea == "BONUS")
                {
                    Console.Write("BONUS DE: ");
                    linea = trova.ReadLine();
                    guanysTotals += Convert.ToInt32(linea);
                    Console.WriteLine(Convert.ToInt32(linea) + "€");
                    i++;
                }
                else if (linea == "NO BONUS")
                    Console.WriteLine(linea);

                linea = trova.ReadLine();
            }
            trova.Close();

            //output
            Console.WriteLine($"el total de guanys aconseguits amb els bonus es de {guanysTotals}€");
            Console.WriteLine($"el total de tickets amb bonus es de {i}");

        }
    }
}