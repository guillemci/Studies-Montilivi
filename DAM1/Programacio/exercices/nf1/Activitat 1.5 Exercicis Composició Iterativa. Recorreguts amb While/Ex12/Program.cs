namespace Ex12
{
    internal class Program
    {
        /// <summary>
        /// Donat el fitxer alumnesDAMDAW.txt, realitza el següent:
        /// ● Llegeix el fitxer i digues si hi ha més alumnes que es diuen Alex, o hi ha més
        /// alumnes que es diuen Iker.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            StreamReader trova = new StreamReader("alumnesDAMDAW.txt");
            string linea;
            int i = 0;
            int contAlex = 0;
            int contIker = 0;

            //inicialitzacio variable
            linea = trova.ReadLine();

            while (linea != null) //condicio de final
            {
                i++;
                //element principal es linea
                if (linea == "Alex") contAlex++;
                if (linea == "Iker") contIker++;
                linea = trova.ReadLine();
            }
            trova.Close();

            Console.WriteLine($"el numero d'Alexs torvats a la llista es de: {contAlex}");
            Console.WriteLine($"el numero d'Ikers torvats a la llista es de: {contIker}");
        }
    }
}
