namespace Ex15B
{
    internal class Program
    {
        //el metex que en el exercici anterior pero utilitzant "new string"
        static void Main(string[] args)
        {
            char caracter = Convert.ToChar(Console.ReadLine());
            int longitud = Convert.ToInt32(Console.ReadLine());

            string lineaGenerada = GenerarLinea(caracter, longitud);

            Console.WriteLine(lineaGenerada);
        }

        //funcio
        public static string GenerarLinea(char car, int longitud)
        {
            //variable
            string linea;

            //objecte
            linea = new string(car, longitud);
            
            //retorn de la funcio
            return linea;
        }
    }
}
