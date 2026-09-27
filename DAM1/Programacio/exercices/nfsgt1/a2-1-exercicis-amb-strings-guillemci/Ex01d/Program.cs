namespace Ex01d
{
    internal class Program
    {
        /// <summary>
        /// 1d) Escriu una funció que retorna una llista d’enters que conté els índexs on apareix target dins de
        /// data. Si target no existeix dins de data, la funció ha de retornar null.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char target = 'a';
            string data = Console.ReadLine();

            List<int> numeros = WhereIs(data, target);

            for (int i = 0; i < numeros.Count; i++)
                Console.WriteLine(numeros[i]);
        }

        public static List<int> WhereIs(String data, char target)
        {
            if (data == null) throw new ArgumentNullException("el string es null");

            List<int> indexs = new List<int>();

            if (data.Contains(target))
            {
                for (int i = 0; i < data.Length; i++)
                    if (data[i] == target) indexs.Add(i);
            }
            return indexs;
        }
    }
}
