namespace Ex01c
{
    internal class Program
    {
        /// <summary>
        /// 1c) Escriu una funció que retorna true si target apareix dins de la cadena data.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char target = 'a';
            string data = Console.ReadLine();

            if (Contains(data, target)) Console.WriteLine("A a sigut trovada");
            else Console.WriteLine("no a sigut trovat");
        }

        public static bool Contains(String data, char target)
        {
            if (data == null) throw new ArgumentNullException("el string es null");

            data = data.ToLower();
            int i = 0;
            bool trovat = false;
            while (i < data.Length && !trovat)
            {
                trovat = data[i] == target;
                i++;
            }

            //return data.Contains(target);
            return trovat;
        }
    }
}
