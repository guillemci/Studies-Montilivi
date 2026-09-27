namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// S'introdueix per teclat el valor del radi r d'una circumferència.
        /// ● Tenim un fitxer anomenat coordenades.txt.
        /// ● Cada línia senar conté una coordenada x.Cada línia parell conté una coordenada y.
        /// -2,6 → coordenada x
        /// 3,8 → coordenada y
        /// . . .
        /// ● El fitxer acaba amb un valor nul per a x per indicar el final.
        /// ● El programa ha d'informar si cada punt està dins, fora o sobre el perímetre de la
        /// circumferència.
        /// ● La circumferència té centre a (0, 0) i radi r.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            StreamReader trova = new StreamReader("coordenades.txt");
            int Radi;
            double x;
            double y;
            string linea;

            //inicialitzacio
            Console.WriteLine("introdueix el radi del cercle");
            Radi = Convert.ToInt32(Console.ReadLine());

            //inicialitzacio primer element
            linea = trova.ReadLine();

            //bucle
            while (linea != null) //condicio final
            {
                //calcul
                x = Convert.ToDouble(linea);
                Console.WriteLine($"la X proporcionada per el programa es {x}");
                x = Math.Pow(x, 2);
                linea = trova.ReadLine();

                y = Convert.ToDouble(linea);
                Console.WriteLine($"la Y proporcionada per el programa es {y}");
                y = Math.Pow(y, 2);

                double distancia;
                distancia = x + y;

                distancia = Math.Round(Math.Sqrt(distancia),2);

                //condicional tractar elements procesats
                if (distancia > Radi) Console.WriteLine($"el punt {distancia} no es trova dints el perimetre");
                else if (distancia < Radi) Console.WriteLine($"el punt {distancia} es trova dints el perimetre");
                else Console.WriteLine($"el punt {distancia} es trova sobre el perimetre");

                linea = trova.ReadLine();
            }
            trova.Close();
        }
    }
}