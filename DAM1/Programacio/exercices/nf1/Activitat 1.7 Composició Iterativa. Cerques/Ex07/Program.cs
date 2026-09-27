namespace Ex07
{
    internal class Program
    {
        /// <summary>
        /// n una cursa de MTB (Mountain Bike), l’organització es pregunta si el ciclista amb el dorsal 231
        /// s’ha perdut.Donada una seqüència de dorsals d’un fitxer que indica els ciclistes que arriben a la
        /// meta, en ordre d’arribada, informa:
        /// a.Si el número 231 ha arribat i, en cas afirmatiu, en quina posició ho ha fet.
        /// b.Si no ha arribat, informar que s’ha perdut.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("TROBAT.TXT");

            const int Condicional = 231;
            string linea;
            int posicio = 0;
            int numeroDelCiclista = 0;
            bool trovat = false;

            while ((linea = trova.ReadLine()) != null && !trovat)
            {
                numeroDelCiclista = Convert.ToInt32(linea);
                posicio++;
                trovat = numeroDelCiclista == Condicional;
            }
            trova.Close();

            if (trovat) Console.WriteLine($"el ciclista a arribat a la posicio numero {posicio}");
            else Console.WriteLine($"el ciclista {posicio} s'ha perdut");
        }
    }
}
