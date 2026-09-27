namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// 10. Feu un programa que ens demani per teclat un any i ens digui a quin segle pertany.
        ///Tan sols considerarem com a anys vàlids els anys que pertanyin al segle XVIII, XIX, XX i
        ///XXI.Sinó es considerarà un any invàlid.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int numerointroduit;
            string resultatPasarNumeroRoma;

            //inicialitzacio
            Console.WriteLine("introdueix aqui l'any a recordar cal tenir clar que els anys que pertanyin al segle XVIII, XIX, XX i XXI son els valids a revisar");
            numerointroduit = Convert.ToInt32(Console.ReadLine());

            //calcul funcio
            resultatPasarNumeroRoma = PasarANumeroRoma(numerointroduit);

            //output
            Console.WriteLine(resultatPasarNumeroRoma);
        }

        static string PasarANumeroRoma(int numerointroduit_)
        {
            string resultat;

            //condicional
            if (numerointroduit_ >= 1701 && numerointroduit_ <= 1800)
            {
                resultat = ($"d'acord al numero introduit {numerointroduit_} el segle en que aquest es situa es el XVIII");
            }
            else if (numerointroduit_ >= 1801 && numerointroduit_ <= 1900)
            {
                resultat = ($"d'acord al numero introduit {numerointroduit_} el segle en que aquest es situa es el XIX");
            }
            else if (numerointroduit_ >= 1901 && numerointroduit_ <= 2000)
            {
                resultat = ($"d'acord al numero introduit {numerointroduit_} el segle en que aquest es situa es el XX");
            }
            else if (numerointroduit_ >= 2001 && numerointroduit_ <= 2100)
            {
                resultat = ($"d'acord al numero introduit {numerointroduit_} el segle en que aquest es situa es el XXI");
            }
            else
            {
                resultat = ($"introdueix un any valid");
            }

            return resultat;
        }
    }
}
