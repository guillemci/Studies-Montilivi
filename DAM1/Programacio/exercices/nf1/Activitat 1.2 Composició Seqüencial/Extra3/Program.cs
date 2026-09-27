namespace Extra3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Càlcul del volum d’una esfera a partir del radi
            /// </summary>
            const double componentForumla = 4.0 / 3.0;
            const double pi = Math.PI;
            double radi;
            double resultat;

            radi = Convert.ToInt32(Console.ReadLine());
            
            resultat = componentForumla * (pi * Math.Pow(radi, 3));

            Console.WriteLine($"el volum de la esfera es de {resultat}");
        }
    }
}