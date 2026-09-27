namespace Exercici02
{
    internal class Program
    {
        /// <summary>
        ///Escriu un programa que et demani per teclat els valors de dos punts i ens mostri el
        ///valor de la distància entre els dos punts.El càlcul cal fer-lo dissenyant una funció
        ///que rebi 4 paràmetres corresponents a les coordenades x i y de cada punti
        ///ens retorni el valor de la distància entre el dos punts.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            double X1, Y1, X2, Y2;
            double distancia;

            //inicialitzacio de variables
            Console.WriteLine("escriu punt 1 especficant x1 i y1");
            Console.WriteLine("Escriu la X1:");
            X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriu la Y1:");
            Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escriu punt 2 especficant x2 i y2");
            Console.WriteLine("Escriu la X2:");
            X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriu la Y2:");
            Y2 = Convert.ToDouble(Console.ReadLine());

            //calcul utilitzant funcio
            distancia = Distancia(X1, Y1, X2, Y2);

            //calculs utilitzant output
            Console.WriteLine($"la distancia entre els punts es de {distancia}");


        }

        //funcio
        static double Distancia(double x1, double y1, double x2, double y2)
        {
            double resultat = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return resultat;
        }
    }
}
