namespace Ex01a
{
    internal class Program
    {
        /// <summary>
        /// 1a) Escriu una funció que retorna true si data és null
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string cadena = null;

            if (IsNull(cadena))
                Console.WriteLine("el valor retornat es null");
        }

        public static bool IsNull(string data)
        {
            return data == null;
        }
    }
}
