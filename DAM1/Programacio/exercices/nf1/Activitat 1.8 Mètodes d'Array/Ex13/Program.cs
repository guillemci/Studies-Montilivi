namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Exercici 13
        /// Donades dues taules ordenades i sense elements repetits, retorna una nova taula amb els elements COMUNS.
        /// </summary>
        static void Main(string[] args)
        {
            int[] t1 = { 1, 4, 7, 9, 15, 20 }; //mes gran
            int[] t2 = { 0, 2, 4, 7 }; //mes petit
            int[] ArrayReturnat = ComunsOrdenades(t1, t2);

            Console.WriteLine("la taula amb els elements repetits a quedat aixi: ");
            for (int i = 0; i < ArrayReturnat.Length; i++)
                Console.Write($"{(ArrayReturnat[i])} ");
        }

        public static int[] ComunsOrdenades(int[] t1, int[] t2)
        {
            // contadors
            int i = 0, j = 0, k = 0;

            //punters normalitzats
            int[] t1_;
            int[] t2_;

            if (t1.Length > t2.Length)
            {
                t1_ = t2; //array mes petit { 0, 2, 4, 7 };
                t2_ = t1; //array mes gran { 1, 4, 7, 9, 15, 20 };
            }
            else
            {
                t2_ = t2; //array mes gran { 1, 4, 7, 9, 15, 20 };
                t1_ = t1; //array mes petit { 0, 2, 4, 7 };
            }

            //longitud array
            while (i < t1_.Length)
            {
                if (t1_[i] == t2_[j]) // iguals
                {
                    k++;
                    i++;
                    j++;
                }
                else if (t1_[i] < t2_[j]) //mes gran
                    i++;

                else if (t1_[i] > t2_[j]) //mes petit
                    j++;
            }

            //nou array
            int[] t3_ = new int[k];

            i = 0;
            j = 0;
            k = 0;

            //array
            while (i < t1_.Length)
            {
                if (t1_[i] == t2_[j]) // iguals
                {
                    t3_ [k] = t1_[i];
                    k++;
                    i++;
                    j++;
                }
                else if (t1_[i] < t2_[j]) //mes gran
                    i++;
                else if (t1_[i] > t2_[j]) //mes petit
                    j++;
            }

            return t3_;
        }
    }
}
