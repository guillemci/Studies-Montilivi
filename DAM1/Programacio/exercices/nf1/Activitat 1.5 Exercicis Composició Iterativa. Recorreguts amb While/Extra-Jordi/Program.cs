namespace Extra_Jordi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variablesss
            int contEnters = 0;
            int contSenar = 0;
            int numeroUsuari = Convert.ToInt32(Console.ReadLine());

            //bucle
            while (numeroUsuari >= 0) //condicio de bucle
            {
                if (numeroUsuari % 2 == 0)
                {
                    contEnters++;
                }
                else
                {
                    contSenar++;
                }

                numeroUsuari = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"total senars es de {contSenar} i total enters es de {contEnters}");
        }
    }
}