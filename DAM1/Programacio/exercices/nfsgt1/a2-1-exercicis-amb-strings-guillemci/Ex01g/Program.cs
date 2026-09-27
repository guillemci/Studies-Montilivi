using System.Text;

namespace Ex01g
{
    internal class Program
    {
        /// <summary>
        /// 1g) Escriu una funció que retorna true si la cadena data és un palíndrom després d’eliminar els
        /// espais en blanc.Per exemple, "racecar" compleix la condició, i "Dennis and Edna sinned" també.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string data = Console.ReadLine();

            if (IsPalindromeWithoutBlanks(data))
                Console.WriteLine($"El text {data} tot i tenir espais es tracta d'un palindrom");

        }

        public static bool IsPalindromeWithoutBlanks(String data)
        {
            if (data == null) throw new ArgumentNullException("el string es null");

            data = data.ToLower();
            data = data.Replace(" ", "");
            StringBuilder datareverse = new StringBuilder();

            for (int i = data.Length - 1; i >= 0; i--)
            {
                datareverse.Append(data[i]);
            }

            string reverse = datareverse.ToString();

            return (reverse == data);
        }
    }
}
