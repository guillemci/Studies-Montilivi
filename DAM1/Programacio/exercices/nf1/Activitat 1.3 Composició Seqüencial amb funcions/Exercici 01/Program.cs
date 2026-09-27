namespace Exercici_01
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa demani a l’usuari una quantitat d'hores, minuts i segons i ens
        /// informi sper la consola del total de temps entrat, convertit tot en segons.El càlcul cal
        /// fer-lo dissenyant una funció que rebi 3 paràmetres enters corresponents a
        /// les hores, minuts i segons i ens retorni un valor enter corresponent a la
        /// conversió a segons.
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int minuts;
            int segons;
            int hores;

            //inicialitzacio de variables
            Console.WriteLine($"introdueix el numero de segons");
            segons = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"introdueix el numero de minuts");
            minuts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"introdueix el numero de hores");
            hores = Convert.ToInt32(Console.ReadLine());

            //calculs utilitzant funcio
            int total = TotalTemps(segons, minuts, hores);

            //output del programa
            Console.WriteLine($"el total d'hores minuts i segons a segons es: {total}");
        }

        //funcio que calcula temps total a segons
        static int TotalTemps(int segons, int minuts, int hores)
        {

            minuts = minuts * 60;
            hores = hores * 3600;
            int total = minuts + hores + segons;
            return total;
        }
    }
}