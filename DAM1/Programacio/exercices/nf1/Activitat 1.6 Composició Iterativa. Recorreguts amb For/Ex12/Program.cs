using System;
using System.Security.Cryptography;

namespace Ex12
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer coordenades2.txt on en la primera línia trobarem la quantitat de coordenades
        ///que té el fitxer i la resta contenen les coordenades de diferents punts amb el següent format: cada
        ///coordenada x a cada línia senar i cada coordenada y a cada línia parell.S'introdueix per teclat el valor
        ///del radi r d'una circumferència.
        ///Un exemple de fitxer amb el format especificat anteriorment:
        ///-2,6 → coordenada x
        ///3,8 → coordenada y
        ///. . .
        ///El programa ha d'informar per a cada punt si està dins, fora o sobre el perímetre de la circumferència
        ///de radi r i centre (0.0).
        ///Crea i utilitza la funció Distancia que retorna la distància d’un punt a l’eix de coordenades.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //objecte
            StreamReader trova = new StreamReader("coordenades2.txt");

            //variables
            int Radi;
            double x;
            double y;
            int totalinas = Convert.ToInt32(trova.ReadLine());
            string linea = trova.ReadLine();
            Console.WriteLine("especifica el radi");
            Radi = Convert.ToInt32(Console.ReadLine());
            
            //bucle
            for (int i = 0; i < totalinas; i++)
            {
                //procesament de
                x = Convert.ToDouble(linea);
                Console.WriteLine($"la X proporcionada per el programa es {x}");
                linea = trova.ReadLine();

                y = Convert.ToDouble(linea);
                Console.WriteLine($"la Y proporcionada per el programa es {y}");

                string cadenaTornada = Distancia(x, y, Radi);
                Console.WriteLine(cadenaTornada);

                linea = trova.ReadLine();
            }
            trova.Close();
        }

        //funcio cridada per el bucle
        public static string Distancia(double x, double y, int Radi)
        {
            //variables dints la funcio
            string cadenaATornar;
            double distancia;

            //calculs
            x = Math.Pow(x, 2);
            y = Math.Pow(y, 2);
            distancia = x + y;
            distancia = Math.Round(Math.Sqrt(distancia), 2);

            //condicional tractar elements procesats
            if (distancia > Radi) cadenaATornar = ($"el punt {distancia} no es trova dints el perimetre");
            else if (distancia < Radi) cadenaATornar = ($"el punt {distancia} es trova dints el perimetre");
            else cadenaATornar = ($"el punt {distancia} es trova sobre el perimetre");

            return cadenaATornar;
        }
    }
}
