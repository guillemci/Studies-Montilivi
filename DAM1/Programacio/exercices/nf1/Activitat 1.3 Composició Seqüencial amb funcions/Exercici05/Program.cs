namespace Exercici05
{
    internal class Program
    {
        /// <summary>
        ///Escriu un programa per convertir una quantitat de polzades a metres.Cal tenir en
        ///compte que una polzada són 2,54 cm.Per assolir el vostre objectiu, cal
        ///dissenyar una funció que rebi un paràmetre corresponent a una quantitat de
        ///polzades.La funció ha de retornar els metres equivalents a les polzades
        ///donades arrodonit amb dues xifres decimals
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            double polzades;
            double metres;

            //Inicialitzacio de variables
            Console.WriteLine("introdueix el nombre de polzades");
            polzades = Convert.ToDouble(Console.ReadLine());

            //calculs fets amb funcio
            metres = PolzadesAMetres(polzades);

            //output
            Console.WriteLine($"les polzades a metres son {metres:F2}m");
        }

        //funcio
        static double PolzadesAMetres(double polzades)
        {
            double resultat = polzades * 2.54 / 100;
            return resultat;
        }
    }
}
