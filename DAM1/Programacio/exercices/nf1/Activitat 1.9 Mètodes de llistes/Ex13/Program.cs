namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Exercici 13
        /// Donades dues llistes ordenades i sense elements repetits, retorna una nova llista amb els elements COMUNS.
        /// </summary>
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 4, 7, 9, 15, 20 }; //mes gran
            List<int> list2 = new List<int> { 0, 2, 4, 7 }; //mes petit
            List<int> ListReturnada = ComunsOrdenades(list1, list2);

            Console.WriteLine("la taula amb els elements repetits a quedat aixi: ");
            for (int i = 0; i < ListReturnada.Count; i++)
                Console.Write($"{(ListReturnada[i])} ");
        }

        public static List<int> ComunsOrdenades(List<int> t1, List<int> t2)
        {
            // contadors
            int i = 0, j = 0, k = 0;

            //punters normalitzats
            List<int> t1_;
            List<int> t2_;

            if (t1.Count > t2.Count)
            {
                t1_ = t2; //array mes petit { 0, 2, 4, 7 };
                t2_ = t1; //array mes gran { 1, 4, 7, 9, 15, 20 };
            }
            else
            {
                t2_ = t2; //array mes gran { 1, 4, 7, 9, 15, 20 };
                t1_ = t1; //array mes petit { 0, 2, 4, 7 };
            }

            List<int> t3_ = new List<int> { };

            //list
            while (i < t1_.Count)
            {
                if (t1_[i] == t2_[j]) // iguals
                {
                    t3_.Add(t1_[i]);
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
