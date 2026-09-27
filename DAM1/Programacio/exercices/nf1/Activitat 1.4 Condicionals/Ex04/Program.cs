namespace Ex04
{
    internal class Program
    {
        /// <summary>
        /// 4. Donat el següent codi, afegeix la condició per a determinar si les tres temperatures
        ///estan en ordre creixent estricte.
        ///int t1 = 24;
        ///int t2 = 25;
        ///int t3 = 26;
        ///bool ordreCreixent;
        ///ordreCreixent = ESCRIU AQUÍ L’EXPRESSIÓ BOOLEANA;
        ///if (ordreCreixent) {
        ///Console.WriteLine("Les temperatures estan en ordre creixent estricte.");
        ///} else {
        ///Console.WriteLine("Les temperatures no estan en ordre creixent estricte.");
        ///}
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int t1 = 24;
            int t2 = 25;
            int t3 = 26;
            bool ordreCreixent;

            //assignacio booleana
            ordreCreixent = t1 < t2 && t2 < t3;

            //condicional
            if (ordreCreixent)
            {
                Console.WriteLine("Les temperatures estan en ordre creixent estricte.");
            }
            else
            {
                Console.WriteLine("Les temperatures no estan en ordre creixent estricte.");
            }
        }
    }
}
