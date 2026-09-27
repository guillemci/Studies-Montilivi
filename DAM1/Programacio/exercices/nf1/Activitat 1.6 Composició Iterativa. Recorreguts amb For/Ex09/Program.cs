namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que demani un número per teclat. El programa ha de mostrar la taula de
        ///multiplicar de l‘1 al 10 del número entrat per teclat.
        ///ENTRA UN NÚMERO: 2
        ///2 x 0 = 0
        ///2 x 1 = 2
        ///...
        ///2 x 10 = 20
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("introdueix el numero del que en vulguis saber la taula");
            int valorUsuari = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"si l'usuari a introduit el valor {valorUsuari} la taula es:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {valorUsuari}  = {i * valorUsuari}");
            }
        }
    }
}
