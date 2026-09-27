namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Hem obtingut els resultats del Girona de la temporada 23/24 en un fitxer CSV.
        /// ● El fitxer Girona lliga23_24.txt.
        /// ● Cada dos files representen una jornada: la primera fila és el resultat del rival
        /// (posicions senars) i la segona és del Girona (posicions parells).
        /// ● Cal comptar els partits guanyats, perduts i empatats del Girona.
        /// ● Cada victòria suma 3 punts i cada empat 1 punt.
        /// ● Calcula el total de punts obtinguts
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            StreamReader trova = new StreamReader("Girona lliga23_24");
            int golRival = 0, golGirona = 0;
            int puntsTotals = 0;
            int partitsGuanyants = 0, partitsPerduts = 0, partitsEmpatats = 0;
            string linea;

            //inicialitzacio
            linea = trova.ReadLine();

            //primer element
            if (linea != null)
            {
                golRival = Convert.ToInt32(linea);
                linea = trova.ReadLine();
            }

            //bucle
            while (linea != null) //condicio bucle
            {
                //els elements son goolGiorna i goolRival

                //condicionals
                if (linea != null)
                {
                    golGirona = Convert.ToInt32(linea);

                    if (golGirona > golRival)
                    {
                        partitsGuanyants++;
                        puntsTotals += 3;
                    }
                    else if (golGirona < golRival) partitsPerduts++;
                    else
                    {
                        partitsEmpatats++;
                        puntsTotals += 1;
                    }

                    linea = trova.ReadLine();
                }

                if (linea != null)
                {
                    golRival = Convert.ToInt32(linea);
                    linea = trova.ReadLine();
                }
            }
            trova.Close();

            //output
            Console.WriteLine($"el total de partits que han guanyat el Girona es de: {partitsGuanyants}");
            Console.WriteLine($"el total de partits que hna perdut el Girona es de: {partitsPerduts}");
            Console.WriteLine($"el total de partits que han enpatat el Girona es de es de: {partitsEmpatats}");
            Console.WriteLine($"el total de punts fets del Girona es de {puntsTotals}");
        }
    }
}