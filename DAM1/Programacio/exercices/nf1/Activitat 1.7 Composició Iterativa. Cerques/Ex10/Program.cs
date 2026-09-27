namespace Ex10
{
    /// <summary>
    /// enim les dades del cens de població del musclo zebra ( Dreissena Polymorpha ) , en el riu Ebre.
    ///Les dades es donen per trams, de forma que el primer número ens dona els musclos del primer tram,
    ///el segon número ens dona els musclos del segon tram, etc.
    ///Tenim la sospita que el musclo zebra ha esdevingut una plaga en el riu.Es considera plaga quan
    ///apareixen 5 o més trams consecutius amb més de 500 exemplars per cada tram.
    ///Escriu un programa que processi una seqüència com la descrita anteriorment, i informi si hi ha plaga o
    ///no hi ha plaga.Observeu els fitxers PLAGA.TXT i NOPLAGA.TXT
    ///Amb el fitxer PLAGA.TXT El programa donarà la sortida HI HA PLAGA
    ///Amb el fitxer PLAGA2.TXT El programa donarà la sortida NO HI HA PLAGA
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("PLAGA.TXT");
            string linea;
            int lineaNumero, cont = 0;
            bool plagaoNo = false;

            while ((linea = trova.ReadLine()) != null && !plagaoNo)
            {
                lineaNumero = Convert.ToInt32(linea);
                if (lineaNumero > 500) cont++;
                plagaoNo = cont == 5;
            }

            if (plagaoNo) Console.WriteLine("hi ha plaga");
            else Console.WriteLine("no hi ha plaga");
        }
    }
}