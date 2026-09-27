namespace Ex02
{
    internal class Program
    {
        /// <summary>
        /// 2) Fes un llistat on apareguin els noms de tots els alumnes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader("ALUMNES.csv");
            string linea;
            linea = read.ReadLine();

            while ((linea = read.ReadLine()) != null)
            {
                string[] partes = linea.Split(';');
                Console.WriteLine(partes[1]);
            }
            read.Close();
        }
    }
}
