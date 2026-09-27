using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Ex08
{
    internal class Program
    {
        /// <summary>
        /// 8- Escriu un programa que llegeixi una seqüència d’enters d’un fitxer i ens informi si es compleix
        /// sempre la condició que l’element llegit és igual a la suma de tots els anteriors que han aparegut.
        /// El resultat del programa és "SÍ" si compleix la condició i "NO" si no la compleix.
        /// (fitxers COMPLEIX.TXT i NOCOMPLEIX.TXT)
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader trova = new StreamReader("COMPLEIX.txt");

            bool final = false;
            string linea = trova.ReadLine();
            int numeroLinea = Convert.ToInt32(linea);
            int acomulats = 0;
            acomulats += numeroLinea;

            while ((linea = trova.ReadLine()) != null && !final)
            {
                numeroLinea = Convert.ToInt32(linea);
                Console.WriteLine(numeroLinea);
                final = numeroLinea != acomulats;
                acomulats += numeroLinea;
                Console.WriteLine(acomulats);
            }
            trova.Close();

            if (final)
                Console.WriteLine("NO");
            else
                Console.WriteLine("SI");
        }
    }
}
