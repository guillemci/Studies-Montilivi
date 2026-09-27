namespace Ex07
{
    internal class Program
    {
        /// <summary>
        /// Fer un programa que vagi demanant números fins trobar el zero i ens digui el valor més gran i
        /// el valor més petit
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int numeroIntroduit;
            int numeroMesGran;
            int numeroMesPetit;
            int cont = 0;

            //inicialitzacio;
            Console.WriteLine("introdueix un numero");
            numeroIntroduit = Convert.ToInt32(Console.ReadLine());
            numeroMesGran = numeroIntroduit;
            numeroMesPetit = numeroIntroduit;

            //bucle
            while (numeroIntroduit != 0) //condicio final
            {
                if (numeroMesGran < numeroIntroduit) 
                numeroMesGran = numeroIntroduit; //element principal

                if (numeroMesPetit > numeroIntroduit)
                {
                    numeroMesPetit = numeroIntroduit; //element principal
                }
                cont++;

                //condicio final actualitzacio
                Console.WriteLine("introdueix un altre numero");
                numeroIntroduit = Convert.ToInt32(Console.ReadLine());
            }

            //output
            Console.WriteLine($"el programa a parat perque has introduit {numeroIntroduit}, el total de numeros introduits a sigut {cont}, el numero mes gran introduit a sigut {numeroMesGran} i el mes petit {numeroMesPetit}");
        }
    }
}
