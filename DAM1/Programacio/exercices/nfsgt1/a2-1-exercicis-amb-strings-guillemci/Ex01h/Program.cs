namespace Ex01h
{
    internal class Program
    {
        /// <summary>
        /// 1h) Escriu una funció que retorna la mateixa cadena data, transformant les lletres minúscules en
        /// majúscules(assumint només lletres de l’alfabet anglès).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            Console.WriteLine(ToUpper(data));
        }

        public static string ToUpper(String data)
        {
            if (data == null) throw new ArgumentNullException("el string es null");
            data = data.ToUpper();
            return data;
        }
    }
}
