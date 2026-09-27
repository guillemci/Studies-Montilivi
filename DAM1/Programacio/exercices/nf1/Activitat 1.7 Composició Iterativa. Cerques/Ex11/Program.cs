using System.Net;

namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// l riu Ebre sospitem que el peix Silur (Silurus glanis) està en perill d’extinció. Considerarem que
        /// el Silur està en perill d’extinció si en algun tram del riu trobem 0 silurs o bé la suma total de silurs en
        /// tots els trams és més petita de 10.
        /// Escriu un programa que, donada una seqüència que indica el nombre de silurs en cada tram, ens
        /// informi si el silur està el perill d’extinció o no ho està.
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("NOPERILL.TXT");
            bool perill2 = false, perill = false;
            int numeroSilurus = 0, acomulacioSilurus = 0;
            string linea;

            while ((linea = trova.ReadLine()) != null && !perill)
            {
                numeroSilurus = Convert.ToInt32(linea);
                acomulacioSilurus += numeroSilurus;
                perill = numeroSilurus == 0;
            }

            perill2 = acomulacioSilurus < 10;

            if (perill || perill2) Console.WriteLine("es trova en parill");
            else Console.WriteLine("no es trova en parill");
        }
    }
}
