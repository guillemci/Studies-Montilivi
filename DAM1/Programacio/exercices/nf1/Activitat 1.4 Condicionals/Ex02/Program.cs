namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// 2. Donat el següent codi, afegeix la condició per a determinar que les tres temperatures
        ///són iguals.
        ///int t1 = 25;
        ///int t2 = 25;
        ///int t3 = 25;
        ///bool iguals;
        ///iguals = ESCRIU AQUÍ L’EXPRESSIÓ BOOLEANA;
        ///if (iguals) {
        ///Console.WriteLine("Les tres temperatures són iguals.");
        ///} else {
        ///Console.WriteLine("Les temperatures no són iguals.");
        ///}
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int t1 = 25;
            int t2 = 25;
            int t3 = 25;
            bool iguals;

            //assignacio booleana
            iguals = t1 == t2 && t2 == t3;

            //condicional
            if (iguals)
            {
                Console.WriteLine("Les tres temperatures són iguals.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són iguals.");
            }
        }
    }
}
