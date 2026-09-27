namespace Exercici08
{
    internal class Program
    {
        ///<summary>
        ///Escriu un programa per mostrar l'hora en format hh:mm:ss a partir d'una quantitat
        ///de segons donada com a entrada.Per exemple, si l'entrada és 4000, la sortida ha de
        ///er 01:04:40. Per fer.ho, dissenyeu una funció que rebi un enter
        ///corresponent a la quantitat de segons i retorni l’string en el format demanat.
        ///</summary>
        static void Main(string[] args)
        {
            //variables
            int segonsapasar_;
            String resultat;

            //inicialitzacio de variables
            Console.WriteLine("introdueix aqui el numero de segons que es volen pasar a hores, minuts...");
            segonsapasar_ = Convert.ToInt32(Console.ReadLine());

            //calcul amb funcio
            resultat = TotASegons(segonsapasar_);

            //output
            Console.WriteLine($"això ens dona la seguent hora: {resultat}");
        }

        //funcio
        static string TotASegons(int segonsapasar)
        {
            int horas = segonsapasar / 3600;
            int minuts = (segonsapasar % 3600) / 60;
            int segons = segonsapasar % 60;
            String temps = ($"{horas:D2}:{minuts:D2}:{segons:D2}");
            return temps;
        }

    }
}