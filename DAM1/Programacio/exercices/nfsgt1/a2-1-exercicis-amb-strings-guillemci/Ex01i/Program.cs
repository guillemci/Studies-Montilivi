namespace Ex01i
{
    internal class Program
    {
        /// <summary>
        /// 1i) Escriu una funció que retorna true si no hi ha cap lletra de l’alfabet anglès dins de data
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            if (NoLetters(data))
                Console.WriteLine("El text no conte cap lletra");
            else
                Console.WriteLine("el text conte lletres");
        }
        public static bool NoLetters(String data)
        {
            if (data == null) throw new ArgumentNullException("el string es null");
            bool noLetters = true;
            char caracter;
            int cont = 0;

            while (cont < data.Length && noLetters)
            {
                caracter = data[cont];
                if ((caracter >= 'a' && caracter <= 'z') || (caracter >= 'A' && caracter <= 'Z'))
                    noLetters = false;
                cont++;
            }

            return noLetters;
        }
    }
}
