namespace Ex01b
{
    internal class Program
    {
        /// <summary>
        /// 1b) Escriu una funció que retorna el nombre d’ocurrències de target dins de data.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char target = 'a';
            string data = Console.ReadLine();
            int trovats = Occurences(data, target);
            Console.WriteLine($"els caracters que corresponen que han sigut trovats son: {trovats}");
        }

        public static int Occurences(string data, char target)
        {
            if (data == null) throw new ArgumentException("el string es null");

            int i = 0;
            int trovats = 0;
            while (i < data.Length)
            {
                if (data[i] == target) trovats++;
                i++;
            }

            return trovats;
        }
    }
}
