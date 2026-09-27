namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Un fitxer anomenat bonus.txt conté una línia per a cada bitllet de loteria venut.
        /// ● Cada línia indica si el bitllet és "BONUS" o "NO BONUS".
        /// ● Si la línia és "BONUS", l'import associat és un enter aleatori entre 1€ i 10€.
        /// ● Crea un programa que processi aquest fitxer.
        /// ● El programa ha de comptar quants bonus s'han distribuït.
        /// ● També ha de calcular el total de bitllets i el percentatge de bitllets guanyadors.
        /// ● El fitxer acaba quan es troba un valor null.
        /// ● També has de calcular el total dels guanys i el nombre de bitllets amb BONUS
        /// </summary>
        static void Main(string[] args)
        {
            //variables
            Random atzar = new Random();
            int valorRandom;
            StreamReader trova = new StreamReader("bonus.txt");
            string linea;
            int i = 0;
            int guanyador = 0;
            int noGuanyador = 0;
            double percentatgeGuanyadors;
            int totalGuanys = 0;

            //inicialitzacio
            linea = trova.ReadLine();

            while (linea != null) //condicio de final
            {
                //element principal linea
                i++;
                if (linea == "BONUS")
                {
                    valorRandom = atzar.Next(1, 11);
                    Console.WriteLine($"el numero {i} te un BONUS de {valorRandom}");
                    guanyador++;
                    totalGuanys += valorRandom;
                }
                if (linea == "NO BONUS") 
                {
                    Console.WriteLine($"el numero {i} no te bonus");
                    noGuanyador++;
                }    
                //valor actualitza bucle
                linea = trova.ReadLine();
            }
            trova.Close();

            //calcul
            percentatgeGuanyadors = Math.Round((double)guanyador / i * 100,0);

            //output
            Console.WriteLine($"el total de tickets distribuits es de: {i}");
            Console.WriteLine($"el total de tickets guanyadors es de: {guanyador}");
            Console.WriteLine($"el total de tickets no guanyadors es de: {noGuanyador}");
            Console.WriteLine($"el percentatge de tickets guanyadors es de: {percentatgeGuanyadors}%");
            Console.WriteLine($"el total de guanys es de: {totalGuanys}");

        }
    }
}