namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// 15. Escriu un programa per tal de sumar un segon a una hora,minut i segon entrat per
        ///teclat.El programa demanarà separadament les hores, minuts i segons i mostrarà tant
        ///l’hora entrada inicialment, com l’hora incrementada en un segon.Cal mostrar en format
        ///hh:mm:ss.
        /// </summary>
        static void Main(string[] args)
        {
            int horesIntroduides;
            int minutsIntroduits;
            int segonsIntroduits;
            string resultat;

            Console.WriteLine("introdueix les hores");
            horesIntroduides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introdueix els minuts");
            minutsIntroduits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introdueix els segons");
            segonsIntroduits = Convert.ToInt32(Console.ReadLine());

            resultat = AfegirSegonsAMinutsIHores(horesIntroduides, minutsIntroduits, segonsIntroduits);

            Console.WriteLine(resultat);
        }

        static string AfegirSegonsAMinutsIHores(int horesIntroduides, int minutsIntroduits, int segonsIntroduits)
        {
            string resultat;


            if (horesIntroduides < 0 || horesIntroduides >= 24 || minutsIntroduits < 0 || minutsIntroduits >= 60 || segonsIntroduits < 0 || segonsIntroduits >= 60)
            {
                return resultat = "Introdueix una hora valida";
            }
            segonsIntroduits++;
            if (segonsIntroduits == 60)
            {
                segonsIntroduits = 0;
                minutsIntroduits++;
            }
            if (minutsIntroduits == 60)
            {
                minutsIntroduits = 0;
                horesIntroduides++;
            }
            if (horesIntroduides == 24)
            {
                horesIntroduides = 0;
            }


            return resultat = ($"l'hora que tindras despres de sumar 1 segon a l'hora introduida es: {horesIntroduides:00}:{minutsIntroduits:00}:{segonsIntroduits:00}");
        }
    }
}