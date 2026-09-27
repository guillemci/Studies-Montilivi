namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// 3. Donat el següent codi, afegeix la condició per a determinar que les tres temperatures
        ///són totes diferents.
        ///int t1 = 25;
        ///int t2 = 25;
        ///int t3 = 24;
        ///bool diferents;
        ///diferents = ESCRIU AQUÍ L’EXPRESSIÓ BOOLEANA;
        ///if (diferents) {
        ///Console.WriteLine("Les tres temperatures són totes diferents.");
        ///} else {
        ///Console.WriteLine("Les temperatures no són totes diferents.");
        ///}
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int t1 = 24;
            int t2 = 25;
            int t3 = 26;
            bool diferents;

            //assignacio booleana
            diferents = t1 != t2 && t2 != t3 && t3 != t1;

            //condicional
            if (diferents)
            {
                Console.WriteLine("Les tres temperatures són totes diferents.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són totes diferents.");
            }
        }
    }
}
