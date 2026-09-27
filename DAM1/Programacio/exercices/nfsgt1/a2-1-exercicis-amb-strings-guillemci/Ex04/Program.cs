using System.Globalization;

namespace Ex04
{
    internal class Program
    {
        /// <summary>
        /// 4) Fes un llistat on aparegui l’edat de cada alumne. En el cas que un alumne sigui menor d'edat,
        /// posar una descripció.Utilitza la següent funció per a calcular l’edat d’un alumne
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
                DateTime naixement = Convert.ToDateTime(partes[3], CultureInfo.GetCultureInfo("es-ES"));
                int edat = CalcularEdat(naixement);
                string resultat = $"{partes[0]} - {partes[1]} {partes[2]} {edat}";
                if (edat < 18) resultat += " (MENOR)";

                Console.WriteLine(resultat);
            }
            read.Close();
        }

        public static int CalcularEdat(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = (DateTime.Now.Year - birthdate.Year);
            if (birthdate.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
