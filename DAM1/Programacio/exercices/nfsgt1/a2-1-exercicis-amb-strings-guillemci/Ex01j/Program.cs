namespace Ex01j
{
    internal class Program
    {
        /// <summary>
        /// 1j) Escriu una funció que retorna true si la primera cadena és més gran que la segona
        /// (alfabèticament).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string primer = "Be";
            string second = "Anna";

            if (GreaterThan(primer, second))
                Console.WriteLine($"{primer} es mes gran");
            else if (!GreaterThan(primer, second))
                Console.WriteLine($"{second} es mes gran");
            else
                Console.WriteLine($"son iguals");
        }

        public static bool GreaterThan(String first, String second)
        {
            if (second == null) throw new ArgumentNullException("el string es null");
            if (first == null) throw new ArgumentNullException("el string es null");
            return first.CompareTo(second) > 0;
        }
    }
}
