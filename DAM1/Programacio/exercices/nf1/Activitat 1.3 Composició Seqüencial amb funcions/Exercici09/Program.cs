namespace Exercici09
{
    internal class Program
    {
        /// <summary>
        ///Escriu un programa per mostrar el volum d’una esfera de radi r i l’àrea i el
        ///perímetre del seu cercle inscrit. Per fer.ho, dissenyeu tres funcions, cadascuna
        ///rep el radi i cadascuna retorna el resultat de cada càlcul. S’ha de retornar un
        ///valor arrodonit amb dues xifres decimals.
        /// </summary>
        static void Main(string[] args)
        {
            //Variable
            double radi;
            double volum;
            double area;
            double perimetre;

            //inicialitzacio
            Console.Write("Posa el radi de la esfera: ");
            radi = Convert.ToDouble(Console.ReadLine());

            //calcul amb funcions
            volum = VolumEsfera(radi);
            area = AreaEsfera(radi);
            perimetre = PerimetreEsfera(radi);

            //output
            Console.WriteLine($"El volum de la esfera es de {volum:0.00}");
            Console.WriteLine($"L'area de la esfera es de {area:0.00}");
            Console.WriteLine($"El perimetre de la esfera es de {perimetre:0.00}");
        }

        //funcio volum esfera
        static double VolumEsfera(double radi)
        {
            double resultat;
            resultat = (4.0 / 3.0) * Math.PI * Math.Pow(radi, 3);
            return Math.Round(resultat, 2);
        }

        //funcio radi esfera
        static double AreaEsfera(double radi)
        {
            double resultat;
            resultat = Math.PI * Math.Pow(radi, 2);
            return Math.Round(resultat, 2);
        }

        //funcio perimetre esfera
        static double PerimetreEsfera(double radi)
        {
            double resultat;
            resultat = 2 * Math.PI * radi;
            return Math.Round(resultat, 2);
        }
    }
}