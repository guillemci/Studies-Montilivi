namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// 11. Considerem el fitxer BONUS3.TXT per al càlcul del BONUS. La primera línia del fitxer conté el
        /// nombre total de bitllets.Cada línia només informa de si el bitllet té un "BONUS" o no. Si la línia té un
        /// "BONUS", la següent línia contindrà el valor "BONUS", i en cas contrari, "NO BONUS". Fes un programa
        /// que processi un fitxer de dades que contingui línies de “BONUS/NO BONUS” en el format indicat i
        /// informi de quants bonus s'han distribuït, quants bitllets hi apareixen en el fitxer i quin percentatge de
        /// bitllets guanyadors hi ha respecte al total.Ha d’indicar també quin és el guany obtingut amb els bonus
        /// trobats al fitxer.
        /// </summary>
        static void Main(string[] args)
        {
            //objecte
            StreamReader trova = new StreamReader("BONUS3.txt");

            //variables
            double valorGuanyBonus = 0;
            int totalAmbBonus = 0;
            int totalBitllets = Convert.ToInt32(trova.ReadLine());
            string numerolineas = trova.ReadLine();

            //bucles
            for (int i = 0; i < totalBitllets; i++)
            {
                //condicionals
                if (numerolineas == "BONUS")
                {
                    double valor = Convert.ToDouble(trova.ReadLine());
                    valorGuanyBonus += valor;
                    totalAmbBonus++;
                    Console.WriteLine($"el bonus numero {i + 1} te un bonus de {valor}");
                }
                else if (numerolineas == "NO BONUS")
                {
                    Console.WriteLine($"el bitllet numero {i + 1} no te bonus");
                }

                //actualitzar linea
                numerolineas = trova.ReadLine();
            }
            trova.Close();

            //calcul
            double percent = (double)totalAmbBonus / totalBitllets * 100;

            //output
            Console.WriteLine($"el total de bitllets a sigut de {totalBitllets}");
            Console.WriteLine($"el total de bitllets guanyadors distributs a sigut de {totalAmbBonus}");
            Console.WriteLine($"el percentatge de bitllets guanyadors a sigut de {percent}");
            Console.WriteLine($"el total guanyat a sigut de {valorGuanyBonus}");

        }
    }
}
