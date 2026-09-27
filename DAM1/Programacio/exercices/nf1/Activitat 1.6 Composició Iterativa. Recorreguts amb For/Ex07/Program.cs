namespace Ex07
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani per teclat un número i calcule la suma del número 1 al número entrat
        /// per l’usuari.
        /// ENTRA UN NÚMERO: 4
        /// 10 //1+2+3+4
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            int valor = 0;
            Console.WriteLine("introdueix el numero del qual en vulguis fer la suma dels seus anteriors");
            int a = Convert.ToInt32(Console.ReadLine());

            //bucle
            for (int i = 0; i <= a; i++)
            {
                 valor += i;
            }

            //output
            Console.WriteLine($"el resultat es: {valor}");
        }
    }
}
