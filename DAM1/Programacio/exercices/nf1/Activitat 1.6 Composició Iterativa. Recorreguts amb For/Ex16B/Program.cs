namespace Ex16B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int k = 0;
            Console.WriteLine("introdueix aqui la longitud de la mitja piramide");
            int j = Convert.ToInt32(Console.ReadLine());
            //bucle

            char car = '*';

            string final = GenerarLinia(car, j);

            Console.WriteLine(final);
        }
        public static string GenerarLinia(char car, int longitud)
        {
            string cadenaFinal = "";

            for (int i = 0; i <= longitud; i++)
            {

                //bucle niat AKA doble bucle
                for (int k = 0; k < i; k++)
                {
                    cadenaFinal += car;
                }

                //fa la nova linea
                cadenaFinal += "\n";

                //també es pot fer amb aquest objecte
                /* 
                string tabs = new string('*', j);
                Console.WriteLine(tabs);
                */
            }

            return cadenaFinal;
        }
    }
}
