namespace Ex01e__var_
{
    internal class Program
    {
        /// <summary>
        /// 1e) Escriu una funció que retorna la cadena data invertida. Per exemple, "ABCDE" ha de retornar
        /// "EDCBA".
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            Console.Write((data));
        }

        public static string Reverse(string data)
        {
            if (data == null) throw new ArgumentNullException("el string es null");

            //podem comberitr una cadena de text a un array d'aquesta manera, ja que string es una cadena de caracters
            char[] charArray = data.ToCharArray();

            //gira els valors d'un array
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
