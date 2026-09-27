using System.Globalization;

namespace Ex05
{
    internal class Program
    {
        /// <summary>
        /// 5) Fes un programa que demani el DNI d’un alumne i que mostri la nota final de l’alumne.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CultureInfo cultura = CultureInfo.GetCultureInfo("es-ES");
            StreamReader read = new StreamReader("ALUMNES.csv");
            string linea;
            bool trobat = false;

            Console.Write("BUSCA DNI: ");
            string dniABuscar = Console.ReadLine();

            linea = read.ReadLine();

            while ((linea = read.ReadLine()) != null && !trobat)
            {
                string[] parts = linea.Split(';');

                if (parts[0] == dniABuscar)
                {
                    trobat = true;
                    double notaExamen = Convert.ToDouble(parts[5], cultura);
                    double notaPractiques = Convert.ToDouble(parts[4], cultura);
                    double faltes = Convert.ToDouble(parts[6], cultura);

                    if (faltes > 20)
                        Console.WriteLine("SUSPES PER FALTES");
                    else
                    {
                        Console.WriteLine($"ALUMNE/A: {parts[1]} {parts[2]}");

                        double notaFinal = (0.30 * notaPractiques) + (0.70 * notaExamen);
                        if ((notaPractiques < 4 || notaExamen < 4) && notaFinal > 4) notaFinal = 4;

                        Console.WriteLine("NOTA: " + notaFinal.ToString("0.##", cultura));

                        if (notaPractiques < 4)
                            Console.WriteLine("(*) nota pràctiques inferior a 4");
                        if (notaExamen < 4)
                            Console.WriteLine("(*) nota examen inferior a 4");
                    }
                }
            }
            read.Close();
        }
    }
}
