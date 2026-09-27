using System.Text;

namespace Ex01e
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
            Console.Write(Reverse(data));
        }

        public static string Reverse(string data)
        {
            if (data == null) throw new ArgumentNullException("el string es null");

            StringBuilder sb = new StringBuilder();

            for (int i = data.Length - 1; i >= 0; i--)
                sb.Append(data[i]);

            string dataRevertida = sb.ToString();
            return dataRevertida;
        }
    }
}