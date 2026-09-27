namespace Ex14
{
    internal class Program
    {
        /// <summary>
        /// /// Exercici 14
        /// Donades dues taules ordenades i sense elements repetits, retorna una nova taula amb els elements NO COMUNS
        /// (elements que estan a t1 però no a t2, i elements de t2 que no estan a t1).
        /// </summary>
        static void Main(string[] args)
        {
            int[] t1 = { 1, 4, 7, 9, 20 }; //mes gran
            int[] t2 = { 0, 2, 4, 6, 15 }; //mes petit
            int[] ArrayReturnat = ComunsOrdenades(t1, t2);

            Console.WriteLine("la taula sense elements repetits a quedat aixi: ");
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

            //nou array
            while (i < t2_.Length)
            {
                if (j < t1_.Length)
                {
                    if (t1_[j] == t2_[i])
                    {
                        i++;
                        j++;
                    }
                    else if (t1_[j] < t2_[i]) //t2 mes gran
                    {
                        j++;
                        k++;
                    }
                    else //t1_[j] > t2_[i] //t1 mes gran
                    {
                        i++;
                        k++;
                    }
                }
            }

            while (j < t1_.Length)
            {
                j++;
                k++;
            }
            while (j < t2_.Length)
            {
                i++;
                k++;
            }

            int[] t3_ = new int[k];

            i = 0;
            j = 0;
            k = 0;

            //array
            while (i < t2_.Length)
            {
                if (j < t1_.Length)
                {
                    if (t1_[j] == t2_[i])
                    {
                        i++;
                        j++;
                    }
                    else if (t1_[j] < t2_[i]) //t2 mes gran
                    {
                        t3_[k] = t1_[j];
                        j++;
                        k++;
                    }
                    else //t1_[j] > t2_[i] //t1 mes gran
                    {
                        t3_[k] = t2_[i];
                        i++;
                        k++;
                    }
                }
            }

            while (j < t1_.Length)
            {
                t3_[k] = t1_[j];
                j++;
                k++;
            }
            while (j < t2_.Length)
            {
                t3_[k] = t2_[i];
                i++;
                k++;
            }

            return t3_;
        }
    }
}
