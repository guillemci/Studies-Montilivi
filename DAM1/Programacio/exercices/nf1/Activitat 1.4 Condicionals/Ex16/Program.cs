namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// 16. L'antiga raça de Gulamatu està molt avançada en el seu esquema de càlcul d'anys.
        ///Entenen què és l'any de traspàs (Un any que és divisible per 4 i no divisible per 100 amb
        ///l'excepció que els anys que són divisibles per 400 també són anys de traspàs.) i també
        ///tenen anys de festa similars.Un és el festival Huluculu(succeeix en anys divisibles per
        ///15) i el festival Bulukulu(succeeix en anys divisibles per 55 sempre que també sigui un
        ///any de traspàs). Amb un any hauràs d'indicar quines propietats tenen aquests anys. Si
        ///l'any no és un any de traspàs ni un any de festival, imprimiu la línia "Aquest és un any
        ///normal". L'ordre d'impressió (si n'hi ha) de les propietats és any de
        ///traspàs-->huluculu-->bulukulu.
        /// </summary>
        static void Main(string[] args)
        {
            int any;
            bool EsAnyTraspas_;
            bool EsAnyHulukulu_;
            bool EsAnyBulukulu_;

            Console.WriteLine("introdueix l'any");
            any = Convert.ToInt32 (Console.ReadLine());

            EsAnyTraspas_ = EsAnyTraspas(any);
            EsAnyHulukulu_ = EsAnyHulukulu(any);
            EsAnyBulukulu_ = EsAnyBulukulu(any);

            if (EsAnyTraspas_) Console.WriteLine("Es un any de traspas");
            if (EsAnyHulukulu_) Console.WriteLine("Es un any Hulukulu");
            if (EsAnyBulukulu_) Console.WriteLine("Es un any Bulukulu");
            if (!EsAnyTraspas_ && !EsAnyHulukulu_ && !EsAnyBulukulu_) Console.WriteLine("Aquest és un any normal");
        }

        static bool EsAnyTraspas(int any_)
        {
            bool resultatCondicionalA = (any_ % 400 == 0) || (any_ % 4 == 0 && any_ % 100 != 0);
            return resultatCondicionalA;
        }

        static bool EsAnyHulukulu(int any_)
        {
            bool resultatCondicionalH = any_ % 15 == 0;
            return resultatCondicionalH;
        }

        static bool EsAnyBulukulu(int any_)
        {
            bool resultatCondicionalB = EsAnyTraspas(any_) && any_ % 55 == 0;
            return resultatCondicionalB;
        }
    }
}
