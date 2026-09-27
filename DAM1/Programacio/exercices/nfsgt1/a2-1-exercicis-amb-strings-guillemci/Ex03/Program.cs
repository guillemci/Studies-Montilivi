using System.Globalization;

namespace Ex03
{
    internal class Program
    {
        /// <summary>
        /// 3) Fes un llistat on apareguin els alumnes que han faltat més d’un 20%. Mostrar el dni, el nom, el
        /// cognom de l’alumne i el percentatge de faltes.Si no hi ha cap alumne que hagi faltat més d’un
        /// 20%, mostra un missatge informatiu.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("es-ES");
            StreamReader read = new StreamReader("ALUMNES.CSV");
            bool hiHaAlumnes = false;
            string linea;

            linea = read.ReadLine();

            while ((linea = read.ReadLine()) != null)
            {
                string[] parts = linea.Split(';');
                double faltes = Convert.ToDouble(parts[6], culture);

                if (faltes > 20)
                {
                    Console.WriteLine($"{parts[0]} - {parts[1]} {parts[2]} ({parts[6]}%)");
                    hiHaAlumnes = true;
                }
            }
            read.Close();

            if (hiHaAlumnes == false)
                Console.WriteLine("Cap alumne ha faltat més d'un 20%.");
        }
    }
}
