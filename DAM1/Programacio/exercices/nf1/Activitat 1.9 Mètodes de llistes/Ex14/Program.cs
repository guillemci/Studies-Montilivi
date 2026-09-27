namespace Ex14
{

    internal class Program
    {
        /// <summary>
        /// Exercici 14
        /// Donades dues llistes ordenades i sense elements repetits, retorna una nova llista amb els elements NO COMUNS
        /// (elements que estan a llista1 però no a llista2, i elements de llista2 que no estan a llista1).
        /// </summary>
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 2, 3, 5 }; //mes gran
            List<int> list2 = new List<int> { 1, 3, 7 }; //mes petit
            List<int> ArrayReturnat = NoComunsOrdenades(list1, list2);

            Console.WriteLine("la taula sense elements repetits a quedat aixi: ");
            for (int i = 0; i < ArrayReturnat.Count; i++)
                Console.Write($"{(ArrayReturnat[i])} ");
        }

        public static List<int> NoComunsOrdenades(List<int> t1, List<int> t2)
        {
            // contadors
            int i = 0, j = 0, k = 0;

            //list
            List<int> t3 = new List<int> { };

            //list emplenada
            while (i < t2.Count && j < t1.Count)
            {
                if (t1[j] == t2[i])
                {
                    i++; j++;
                }
                else if (t1[j] < t2[i]) //t2 mes gran
                {
                    t3.Add(t1[j]); j++;
                }
                else //t1_[j] > t2_[i] //t1 mes gran
                {
                    t3.Add(t2[i]); i++;
                }
            }

            while (j < t1.Count)
            {
                t3.Add(t1[j]); j++;
            }
            while (i < t2.Count)
            {
                t3.Add(t2[i]); i++;
            }

            return t3;
        }
    }
}
