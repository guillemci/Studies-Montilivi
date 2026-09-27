namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa per que faci el següent:
        /// a.Genera dos nombres entre 1 i 100 a l’atzar
        /// b.Ens demana el resultat de la suma, resta, producte i divisió entera
        /// c.Si encertem tots els resultats, el programa acaba
        /// d. Si fallem algun resultat, tornem a repetir des de l’apartat a) fins l’apartat d.
        /// e.Quan el procés acaba, ens ha d’informar de quantes iteracions han calgut per poder
        /// completar correctament les 4 operacions
        /// </summary>
        static void Main(string[] args)
        {
            //variables i inicialitzacio
            Random atzar = new Random();
            double resultatDiferentsOperacions;
            double usuariEndivina;
            int puntuacioCorrectes = 0;
            int i = 0;
            int j = 0;
            int valorRandom1;
            int valorRandom2;

            //bucle
            while (puntuacioCorrectes != 4) //condicio de bucle final
            {
                //atzar.Next(1, 101)
                //variables inicialitzades dints el bucle dints el bucle
                valorRandom1 = atzar.Next(1, 101);
                valorRandom2 = atzar.Next(1, 101);

                //output dels numeros proporcionats
                Console.WriteLine($"els numeros generats aleatoriament son els seguents: valor1:{valorRandom1} i valor2:{valorRandom2}");

                //calcul suma dels dos numeros
                Console.WriteLine("fes la suma");
                resultatDiferentsOperacions = valorRandom1 + valorRandom2;
                Console.WriteLine("introdueix el valor que creguis correcte");
                usuariEndivina = Convert.ToInt32(Console.ReadLine());
                if (resultatDiferentsOperacions == usuariEndivina) puntuacioCorrectes++;

                //calcul resta dels dos numeros
                Console.WriteLine("fes la resta");
                resultatDiferentsOperacions = valorRandom1 - valorRandom2;
                Console.WriteLine("introdueix el valor que creguis correcte");
                usuariEndivina = Convert.ToInt32(Console.ReadLine());
                if (resultatDiferentsOperacions == usuariEndivina) puntuacioCorrectes++;

                //calcul multiplicacio dels dos numeros
                Console.WriteLine("fes la multiplicacio");
                resultatDiferentsOperacions = valorRandom1 * valorRandom2;
                Console.WriteLine("introdueix el valor que creguis correcte");
                usuariEndivina = Convert.ToInt32(Console.ReadLine());
                if (resultatDiferentsOperacions == usuariEndivina) puntuacioCorrectes++;

                //calcul divisio dels dos numeros
                Console.WriteLine("fes la divisio");
                resultatDiferentsOperacions = Math.Round((double)valorRandom1 / valorRandom2, 2);
                Console.WriteLine("introdueix el valor que creguis correcte");
                usuariEndivina = Convert.ToDouble(Console.ReadLine());
                if (resultatDiferentsOperacions == usuariEndivina) puntuacioCorrectes++;

                //comprovacio repeticio bucle final
                if (puntuacioCorrectes != 4)
                {
                    Console.WriteLine($"has fet una puntuacio de {puntuacioCorrectes} n'has de fer 4, torna-ho a fer");
                    puntuacioCorrectes = 0;
                    j++;
                }
            }

            //output
            Console.WriteLine($"has endevinat correctement cada resultat i la teva puntuacio es de {puntuacioCorrectes}");
            Console.WriteLine($"iteracions necesitades {j}");
        }
    }
}